using Microsoft.EntityFrameworkCore;

namespace ClothingSizeApi.Models
{
    public class ClothingSizeApiContext : DbContext
    {
        public ClothingSizeApiContext(DbContextOptions<ClothingSizeApiContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
    }
}