using Demo03_Versioning_2.Data_Access;
using Demo03_Versioning_2.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo03_Versioning_2.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IActionResult GetV1()
        {
            var countries = CountriesData.Get();
            var countriesDto = new List<CountryDtoV1>();
            foreach(var country in countries)
            {
                countriesDto.Add(new CountryDtoV1 { Id = country.Id, Name = country.Name });
            }
            return Ok(countriesDto);
        }
        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult GetV2()
        {
            var countries = CountriesData.Get();
            var countriesDto = new List<CountryDtoV2>();
            foreach (var country in countries)
            {
                countriesDto.Add(new CountryDtoV2 { Id = country.Id, CountryName = country.Name });
            }
            return Ok(countriesDto);
        }
    }
}
