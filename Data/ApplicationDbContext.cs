using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Data
{
	public class ApplicationDbContext : DbContext
	{

		public DbSet<Villa> Villas { get; set; }
		public DbSet<NumberVilla> NumberVillas { get; set; }


		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Villa>().HasData(
				new Villa()
				{
					Id = 1,
					Name = "Villa Real",
					Detail = "Detalle de la villa",
					ImageUrl = "",
					Ocuppants = 5,
					SquareMeters = 50,
					Rate = 200,
					Amenity = "",
					CreationDate = DateTime.Now,
					UpdateDate = DateTime.Now
				},
				new Villa()
				{
					Id = 2,
					Name = "Premium Vista al Mar",
					Detail = "Detalle de la villa",
					ImageUrl = "",
					Ocuppants = 4,
					SquareMeters = 40,
					Rate = 150,
					Amenity = "",
					CreationDate = DateTime.Now,
					UpdateDate = DateTime.Now
				},

                new Villa()
                {
                    Id = 3,
                    Name = "Premium Vista al Mar",
                    Detail = "Detalle de la villa",
                    ImageUrl = "",
                    Ocuppants = 4,
                    SquareMeters = 40,
                    Rate = 150,
                    Amenity = "",
                    CreationDate = DateTime.Now,
					UpdateDate = DateTime.Now
				}
            );
		}
	}
}

