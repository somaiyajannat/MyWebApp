using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "ScienceFiction", DisplayOrder = 1 },
                new Category { CategoryId = 3, Name = "Gaming", DisplayOrder = 10 }

                );
            modelBuilder.Entity<Product>().HasData(
                new Product { productId = 1, ProductName = "Pen", ProductDescription = "Fountain pen" },
                new Product { productId = 2, ProductName = "Books", ProductDescription = "Comic Books" },
                new Product { productId = 3, ProductName = "Mouse", ProductDescription = "Microsoft Mouse" }
                );
            }
        }

    }

