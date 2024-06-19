using AutoMapper;
using Demo_01.DataAccess;
using Demo_01.Models.Domain;
using Demo_01.Models.DTOs;
using Demo_01.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_01.Controllers
{
    // https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        // GET:
        // https://localhost:portnumber/api/regions
        [HttpGet]
        //[Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> GetAll()
        {   
            // Get regions domain model
            var regionsDomain = await regionRepository.GetAllAsync();

            // Map from list regions domain to list regions DTO then return 200 status  
            return Ok(mapper.Map<List<RegionDTO>>(regionsDomain));
        }

        // GET:
        // https://localhost:portnumber/api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            // Find region domain model by id
            var regionDomain = await regionRepository.GetByIdAsync(id);

            // If not found, return 404 status
            if(regionDomain == null) return NotFound();

            // If found, map from region domail model to region DTO then return 200 status
            return Ok(mapper.Map<RegionDTO>(regionDomain));
        }

        // POST:
        // https://localhost:portnumber/api/regions
        [HttpPost] 
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDTO addRegionRequestDTO)
        {
            // Map from AddRegionRequestDTO to region domain model
            var regionDomain = mapper.Map<Region>(addRegionRequestDTO);

            // Add region domain model to database
            await regionRepository.CreateAsync(regionDomain);

            // Map from region domain model to region DTO then return 201 status
            var regionDTO = mapper.Map<RegionDTO>(regionDomain);
            return CreatedAtAction(nameof(Get), new { regionDTO.Id }, regionDTO);
        }

        // PUT:
        // https://localhost:portnumber/api/regions/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDTO updateRegionRequestDTO)
        {
            // Map from region update dto to region domain
            var regionDomain = mapper.Map<Region>(updateRegionRequestDTO);

            // Get region domain model by id and update
            regionDomain = await regionRepository.UpdateAsync(id, regionDomain);
            if(regionDomain == null)
            {
                return NotFound();
            }

            // Map from region domain to region DTO and then return 200 status
            return Ok(mapper.Map<RegionDTO>(regionDomain));
        }

        // DELETE:
        // https://localhost:portnumber/api/regions/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Get region domain by id
            var regionDomain = await regionRepository.DeleteAsync(id);
            if (regionDomain == null) return NotFound();

            // Map from region domain model to region DTO
            return Ok(mapper.Map<RegionDTO>(regionDomain));
        }
    }
}
