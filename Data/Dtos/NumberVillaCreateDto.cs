using System.ComponentModel.DataAnnotations;

namespace Data.Dtos
{
    public class NumberVillaCreateDto
    {
        [Required]
        public int VillaNumber { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetail { get; set; }
    }
}
