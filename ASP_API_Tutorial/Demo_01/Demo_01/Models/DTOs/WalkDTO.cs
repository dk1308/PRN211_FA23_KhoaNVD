using Demo_01.Models.Domain;

namespace Demo_01.Models.DTOs
{
    public class WalkDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageURL { get; set; }

        // Navigation properties
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
