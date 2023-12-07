using System.ComponentModel.DataAnnotations;

namespace Demo_01_UI.Models.DTOs
{
    public class AddRegionViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageURL { get; set; }
    }
}
