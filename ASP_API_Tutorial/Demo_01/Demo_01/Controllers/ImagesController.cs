using Demo_01.Models.Domain;
using Demo_01.Models.DTOs;
using Demo_01.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Demo_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;
        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> UploadImage([FromForm] UploadImageRequestDTO request)
        {
            ValidateImage(request);
            if(ModelState.IsValid)
            {
                // Upload image from repository
                var imageDomain = new Image
                {
                    File = request.File,
                    FileName = request.FileName,
                    FileDescription = request.FileDescription,
                    FileExtension = Path.GetExtension(request.File.FileName),
                    FileSizeInBytes = request.File.Length
                };

                imageDomain = await imageRepository.Upload(imageDomain);
                return Ok(imageDomain);
            }
            return BadRequest(ModelState);
        }

        private void ValidateImage(UploadImageRequestDTO request)
        {
            var acceptedExtension = new string[] { ".jpg", ".png", ".jpeg" };
            if(!acceptedExtension.Contains(Path.GetExtension(request.File.FileName)))
            {
                ModelState.AddModelError("file", "File is invalid extension");
            }

            if(request.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File length is larger than 10MB");
            }
        }
    }
}
