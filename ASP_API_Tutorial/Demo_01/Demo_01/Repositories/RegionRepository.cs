using Demo_01.Data_Access;
using Demo_01.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Demo_01.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalkMnDBContext dBContext;

        public RegionRepository(WalkMnDBContext dBContext) {
            this.dBContext = dBContext;
        }
        public async Task<Region> CreateAsync(Region region)
        {
            await dBContext.AddAsync(region);
            await dBContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            var existingRegion = await dBContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
            if (existingRegion == null) return null;
            
            dBContext.Regions.Remove(existingRegion);
            await dBContext.SaveChangesAsync();

            return existingRegion;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await dBContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            var region = await dBContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
            return region;
        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var existingRegion = await dBContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
            if (existingRegion == null) return null;

            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageURL = region.RegionImageURL;
            
            await dBContext.SaveChangesAsync();
            return existingRegion;
        }
    }
}
