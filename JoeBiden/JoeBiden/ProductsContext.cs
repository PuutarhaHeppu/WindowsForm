using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeBiden
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Piim" },
                new Category { CategoryId = 2, Name = "Puuviljad" },
                new Category { CategoryId = 3, Name = "Marjad" },
                new Category { CategoryId = 4, Name = "Köögiviljad" });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Sojapiim" },
                new Product { ProductId = 2, CategoryId = 1, Name = "Kaerapiim" },
                new Product { ProductId = 3, CategoryId = 1, Name = "Laktoosivaba piim" },
                new Product { ProductId = 4, CategoryId = 1, Name = "Mandlipiim" },
                new Product { ProductId = 5, CategoryId = 1, Name = "Kookospiim" },
                new Product { ProductId = 6, CategoryId = 1, Name = "Toorpiim" },
                new Product { ProductId = 7, CategoryId = 1, Name = "Täispiim" },
                new Product { ProductId = 8, CategoryId = 1, Name = "Riisipiim" },
                new Product { ProductId = 9, CategoryId = 1, Name = "Kanepipiim" },
                new Product { ProductId = 10, CategoryId = 2, Name = "Lime" },
                new Product { ProductId = 11, CategoryId = 2, Name = "Banaan" },
                new Product { ProductId = 12, CategoryId = 2, Name = "Arpuus" },
                new Product { ProductId = 13, CategoryId = 2, Name = "Õun" },
                new Product { ProductId = 14, CategoryId = 2, Name = "Pirn" },
                new Product { ProductId = 15, CategoryId = 2, Name = "Apelsiin" },
                new Product { ProductId = 16, CategoryId = 2, Name = "Kiivi" },
                new Product { ProductId = 17, CategoryId = 2, Name = "Mango" },
                new Product { ProductId = 18, CategoryId = 3, Name = "Maasikas" },
                new Product { ProductId = 19, CategoryId = 3, Name = "Mustikas" },
                new Product { ProductId = 20, CategoryId = 3, Name = "Vaarikas" },
                new Product { ProductId = 21, CategoryId = 3, Name = "Kirss" },
                new Product { ProductId = 22, CategoryId = 4, Name = "Kartul" },
                new Product { ProductId = 23, CategoryId = 4, Name = "Baklažaan" },
                new Product { ProductId = 24, CategoryId = 4, Name = "Bataat" },
                new Product { ProductId = 25, CategoryId = 4, Name = "Roheline sibul" },
                new Product { ProductId = 26, CategoryId = 4, Name = "Kapsas" },
                new Product { ProductId = 27, CategoryId = 4, Name = "Hernes" },
                new Product { ProductId = 28, CategoryId = 4, Name = "Tomat" });
        }
    }
}
