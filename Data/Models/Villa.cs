using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
	public class Villa
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Detail { get; set; }
		public string ImageUrl { get; set; }
		public string Amenity { get; set; }
        public int Ocuppants { get; set; }
        public double SquareMeters { get; set; }
		[Required]
        public double Rate { get; set; }
		public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

