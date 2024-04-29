using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Dtos
{
    public class NumberVillaUpdateDto
    {
        [Required]
        public int VillaNumber { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetail { get; set; }
    }
}
