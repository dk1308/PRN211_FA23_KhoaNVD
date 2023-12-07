using Demo03_Versioning_2.Models.Domains;

namespace Demo03_Versioning_2.Data_Access
{
    public class CountriesData
    {
        public static List<Country> Get() 
        {
            var countries = new[]
            {
                new {Id = 1, Name = "America"},
                new {Id = 2, Name = "Vietnam"},
                new {Id = 3, Name = "France"},
                new {Id = 4, Name = "Germany"},
                new {Id = 5, Name = "Japan"},
                new {Id = 6, Name = "Argentina"},
            };
            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
