using Demo_01.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Demo_01.Repositories
{
    public interface IWalkRepository
    {
        Task<List<Walk>> GetAllAsync(string? filterOn, string? filterQuerry,string? sortBy, bool isAccending
                                    , int pageNumber, int pageSize);
        Task<Walk> CreateAsync(Walk walk);
        Task<Walk?> GetByIdAsync(Guid id);
        Task<Walk?> UpdateAsync(Guid id, Walk walk);
        Task<Walk?> DeleteAsync(Guid id);
    }
}
