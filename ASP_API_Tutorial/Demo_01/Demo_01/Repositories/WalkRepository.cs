using Demo_01.DataAccess;
using Demo_01.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Demo_01.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly WalkMnDBContext dBContext;

        public WalkRepository(WalkMnDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dBContext.Walks.AddAsync(walk);
            await dBContext.SaveChangesAsync();
            return walk;
        }

        public async Task<Walk?> DeleteAsync(Guid id)
        {
            var existingWalk = await dBContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(w => w.Id == id);
            if (existingWalk == null)  return null; 
            dBContext.Walks.Remove(existingWalk);
            await dBContext.SaveChangesAsync();
            return existingWalk;
        }

        public async Task<List<Walk>> GetAllAsync(string? filterOn, string? filterQuerry, string? sortBy, bool isAccending = true,
                                            int pageNumber=1, int pageSize=1000)
        {

            // Filtering
            var walks = dBContext.Walks.Include("Difficulty").Include("Region").AsQueryable();
            if (!string.IsNullOrEmpty(filterOn))
            {
                if(filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = walks.Where(w => w.Name.Contains(filterQuerry));
                }
            }

            // Sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                if(sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAccending ? walks.OrderBy(w => w.Name) : walks.OrderByDescending(w => w.Name); 
                }
                if (sortBy.Equals("Length", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAccending ? walks.OrderBy(w => w.LengthInKm) : walks.OrderByDescending(w => w.LengthInKm);
                }
            }

            // Pagination
            var skipWalksNumber = (pageNumber-1)*pageSize; 

            return await walks.Skip(skipWalksNumber).Take(pageSize).ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
            return await dBContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(w => w.Id == id);
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk = await dBContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(w => w.Id == id);
            if (existingWalk == null) return null;

            existingWalk.Name = walk.Name;
            existingWalk.Description = walk.Description;
            existingWalk.LengthInKm = walk.LengthInKm;
            existingWalk.WalkImageURL = walk.WalkImageURL;
            existingWalk.DifficultyId = walk.DifficultyId;
            existingWalk.RegionId = walk.RegionId;

            await dBContext.SaveChangesAsync();

            return existingWalk;
        }
    }
}
