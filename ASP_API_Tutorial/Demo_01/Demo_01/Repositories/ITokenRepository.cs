using Microsoft.AspNetCore.Identity;

namespace Demo_01.Repositories
{
    public interface ITokenRepository
    {
        public string CreateToken(IdentityUser user, List<string> roles);
    }
}
