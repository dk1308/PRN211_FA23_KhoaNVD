using Demo_01.DataAccess;
using Demo_01.Models.Domain;

namespace Demo_01.Repositories
{
    public class LocalImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly WalkMnDBContext dBContext;

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment
                        , IHttpContextAccessor httpContextAccessor
                        , WalkMnDBContext dBContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
            this.dBContext = dBContext;
        }
        public async Task<Image> Upload(Image image)
        {
            // Upload image to physical file path
            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images",
                $"{image.FileName}{image.FileExtension}");
            using var stream = new FileStream(localFilePath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            // Set local path to image
            var hostPath = $"{httpContextAccessor.HttpContext.Request.Scheme}://" +
                $"{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}" +
                $"/Images/{image.FileName}{image.FileExtension}";
            image.FilePath = hostPath;
            await dBContext.Images.AddAsync(image);
            await dBContext.SaveChangesAsync();
            return image;
        }
    }
}
