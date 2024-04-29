using System.ComponentModel.DataAnnotations;

namespace Data.Dtos
{
	public class VillaDto
	{
		public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public int Ocuppants { get; set; }
        public double SquareMeters { get; set; }
        [Required]
        public double Rate { get; set; }
    }
}

