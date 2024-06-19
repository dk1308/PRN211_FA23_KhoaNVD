using Demo02_Versioning.Data_Access;
using Demo02_Versioning.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo02_Versioning.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var countriesDomain = CountriesDataProvider.Get();
            var countriesDto = new List<CountryDtoV1>();
            foreach (var c in countriesDomain)
            {
                countriesDto.Add(new CountryDtoV1
                {
                    Id = c.Id,
                    Name = c.Name,
                });
            }
            return Ok(countriesDto);
        }
    }
}
