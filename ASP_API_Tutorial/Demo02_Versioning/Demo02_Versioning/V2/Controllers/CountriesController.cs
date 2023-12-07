using Demo02_Versioning.Data_Access;
using Demo02_Versioning.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo02_Versioning.V2.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var countriesDomain = CountriesDataProvider.Get();
            var countriesDto = new List<CountryDtoV2>();
            foreach (var c in countriesDomain)
            {
                countriesDto.Add(new CountryDtoV2
                {
                    Id = c.Id,
                    CountryName = c.Name,
                });
            }
            return Ok(countriesDto);
        }
    }
}
