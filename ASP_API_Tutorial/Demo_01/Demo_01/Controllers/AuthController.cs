using Demo_01.Models.DTOs;
using Demo_01.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }
        // POST: api/Auth/Register
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterRequestDTO registerRequestDTO)
        {
            // Initialize identity user
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDTO.Username,
                Email = registerRequestDTO.Username
            };
            // Set password to identity user and create 
            var identityResult = await userManager.CreateAsync(identityUser, registerRequestDTO.Password);
            // Check if succeed, add roles
            if (identityResult.Succeeded)
            {
                if(registerRequestDTO.Roles != null)
                {
                    await userManager.AddToRolesAsync(identityUser, registerRequestDTO.Roles);
                    if (identityResult.Succeeded) return Ok(identityUser);
                }
            }
            return BadRequest("Something went wrong!");
        }

        // POST: api/Auth/Login
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            var account = await userManager.FindByEmailAsync(loginRequestDTO.Username);
            if(account!= null)
            {
                var isValidPassword = await userManager.CheckPasswordAsync(account, loginRequestDTO.Password);
                if(isValidPassword)
                {
                    var roles = await userManager.GetRolesAsync(account);
                    // Create token
                    if(roles != null)
                    {
                        var jwtToken = tokenRepository.CreateToken(account, roles.ToList());
                        var loginRespone = new LoginResponeDTO
                        {
                            JwtToken = jwtToken
                        };
                        return Ok(loginRespone);
                    }
                }
            }
            return BadRequest("Username or password is incorrect!");
        }
    }
}
