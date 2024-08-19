using Microsoft.EntityFrameworkCore;
using SpicyWorld.Models;

namespace SpicyWorld.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categoiries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
     new Category { Id = 1, Name = "Mild", Description = "A gentle touch of spice for those who prefer a subtle flavor.", DisplayOrder = 1 },
     new Category { Id = 2, Name = "Medium", Description = "A balanced level of spice that adds a bit of heat without overwhelming.", DisplayOrder = 2 },
     new Category { Id = 3, Name = "Hot", Description = "For those who enjoy a strong kick of spice that packs a punch.", DisplayOrder = 3 },
     new Category { Id = 4, Name = "Extra Hot", Description = "Intense heat for spice lovers who crave a fiery experience.", DisplayOrder = 4 },
     new Category { Id = 5, Name = "Super Spicy", Description = "A blazing level of spice that challenges even the bravest.", DisplayOrder = 5 }
 );

        }
    }
}
