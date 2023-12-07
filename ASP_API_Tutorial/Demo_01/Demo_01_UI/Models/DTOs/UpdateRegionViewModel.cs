using System.ComponentModel.DataAnnotations;

namespace Demo_01_UI.Models.DTOs
{
    public class UpdateRegionViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageURL { get; set; }
    }
}
