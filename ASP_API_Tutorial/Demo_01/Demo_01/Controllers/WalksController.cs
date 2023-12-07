using AutoMapper;
using Demo_01.Models.Domain;
using Demo_01.Models.DTOs;
using Demo_01.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IWalkRepository walkRepository;
        private readonly IMapper mapper;
        private readonly ILogger<WalksController> logger;

        public WalksController(IWalkRepository walkRepository, IMapper mapper
                    , ILogger<WalksController> logger)
        {
            this.walkRepository = walkRepository;
            this.mapper = mapper;
            this.logger = logger;
        }

        // POST: api/Walks
        [HttpPost]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDTO addWalkRequestDTO)
        {
            var walkDomain = await walkRepository.CreateAsync(mapper.Map<Walk>(addWalkRequestDTO));

            return CreatedAtAction(nameof(GetById), new { walkDomain.Id }, mapper.Map<WalkDTO>(walkDomain));
        }

        // GET: api/Walks?filterOn=Mame&filterQuerry=track&sortBy=Name&isAccending=true&pageNumber=1&pageSize=1000
        [HttpGet]
        //[Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuerry,
                                [FromQuery] string? sortBy, [FromQuery] bool? isAccending,
                                [FromQuery] int pageNumber=1, [FromQuery] int pageSize =1000)
        {
            List<Walk> walks = await walkRepository.GetAllAsync(filterOn, filterQuerry, sortBy, isAccending ?? true, pageNumber, pageSize);
            return Ok(mapper.Map<List<WalkDTO>>(walks));
        }

        // GET: api/Walks/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walk = await walkRepository.GetByIdAsync(id);
            if (walk == null) return NotFound();
            return Ok(mapper.Map<WalkDTO>(walk));
        }

        // PUT: api/Walks/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWalkRequestDTO updateWalkRequestDTO)
        {
            var updatedWalk = mapper.Map<Walk>(updateWalkRequestDTO);
            updatedWalk = await walkRepository.UpdateAsync(id, updatedWalk);

            if (updatedWalk == null) return NotFound();
            return Ok(mapper.Map<WalkDTO>(updatedWalk));
        }

        // DELETE: api/Walks/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var walk = await walkRepository.DeleteAsync(id);
            if(walk == null) return NotFound();
            return Ok(mapper.Map<WalkDTO>(walk));
        }
    }
}
