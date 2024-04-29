using System.ComponentModel.DataAnnotations;

namespace Data.Dtos
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Detail { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Amenity { get; set; }
        [Required]
        public int Ocuppants { get; set; }
        [Required]
        public double SquareMeters { get; set; }
        public double Rate { get; set; }
    }
}

