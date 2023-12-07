using Demo_01.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace Demo_01.Data_Access
{
    public class WalkMnDBContext: DbContext
    {
        public WalkMnDBContext(DbContextOptions<WalkMnDBContext> dbContextOptions):base(dbContextOptions) 
        {
            
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding data for Difficulties
            var difficulties = new List<Difficulty>()
            {
                new Difficulty
                {
                    Id = Guid.Parse("036e75cd-1128-4c78-93d4-51f437ba8a94"),
                    Name = "Easy"
                },
                new Difficulty
                {
                    Id = Guid.Parse("b0bec5cd-4581-4458-8835-81748510430b"),
                    Name = "Medium"
                },
                new Difficulty
                {
                    Id = Guid.Parse("5592ee1d-a714-4604-b2c9-03de327c8c5e"),
                    Name = "Hard"
                }
            };
            // Seeding Difficulties to database 
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seeding data for Regions
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageURL = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageURL = null
                },
                new Region
                {
                    Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageURL = null
                },
                new Region
                {
                    Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageURL = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageURL = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageURL = null
                }
            };
            // Seeding Regions to database
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
