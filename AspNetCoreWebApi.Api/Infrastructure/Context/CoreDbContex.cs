using AspNetCoreWebApi.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Api.Infrastructure.Context
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
           
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Çorbalar", Description="Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 2, CategoryName = "Kebaplar", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 3, CategoryName = "Salatalar", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 4, CategoryName = "İçecekler", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 5, CategoryName = "Balıklar", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 6, CategoryName = "Sulu Yemekler", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 7, CategoryName = "Meyveler", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 8, CategoryName = "Tatlılar", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true },
                new Category { Id = 9, CategoryName = "Kuru Yemiş", Description = "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi ürünlerimiz ile profesyonel ekibimizle hazırlanmış günlük yemekler. ", IsActive = true }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Mercimek", IsActive = true, Price = 5, Stock = 100 },
                new Product { Id = 2, CategoryId = 1, Name = "Ezogelin", IsActive = true, Price = 5, Stock = 95 },
                new Product { Id = 3, CategoryId = 2, Name = "İskender", IsActive = true, Price = 25, Stock = 70 },
                new Product { Id = 4, CategoryId = 2, Name = "Adana", IsActive = true, Price = 25, Stock = 80 },
                new Product { Id = 5, CategoryId = 3, Name = "Mevsim", IsActive = true, Price = 8, Stock = 100 },
                new Product { Id = 6, CategoryId = 3, Name = "Havuç", IsActive = true, Price = 6, Stock = 40 },
                new Product { Id = 7, CategoryId = 4, Name = "Kola", IsActive = true, Price = 4, Stock = 150 },
                new Product { Id = 8, CategoryId = 4, Name = "Ayran", IsActive = true, Price = 3, Stock = 200 },
                new Product { Id = 9, CategoryId = 5, Name = "Kuru Fasülye", IsActive = true, Price = 12, Stock = 90 },
                new Product { Id = 10, CategoryId = 5, Name = "Bezelye", IsActive = true, Price = 10, Stock = 70 },
                new Product { Id = 11, CategoryId = 6, Name = "Uskumru", IsActive = true, Price = 25, Stock = 25 },
                new Product { Id = 12, CategoryId = 6, Name = "Hamsi Tava", IsActive = true, Price = 25, Stock = 40 },
                new Product { Id = 13, CategoryId = 7, Name = "Portakal", IsActive = true, Price = 1, Stock = 300 },
                new Product { Id = 14, CategoryId = 7, Name = "Elma", IsActive = true, Price = 1, Stock = 275 },
                new Product { Id = 15, CategoryId = 8, Name = "Baklava", IsActive = true, Price = 10, Stock = 100 },
                new Product { Id = 16, CategoryId = 8, Name = "Sütlaç", IsActive = true, Price = 8, Stock = 100 },
                new Product { Id = 17, CategoryId = 9, Name = "Fındık", IsActive = true, Price = 5, Stock = 1000 },
                new Product { Id = 18, CategoryId = 9, Name = "Fıstık", IsActive = true, Price = 5, Stock = 1000 }
            );
        }
    }
}
