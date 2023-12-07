using Demo_01.Models.Domain;

namespace Demo_01.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
