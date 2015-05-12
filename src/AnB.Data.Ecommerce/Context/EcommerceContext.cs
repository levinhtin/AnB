using System;
using Microsoft.Data.Entity;
using AnB.Data.Ecommerce.Models;

namespace AnB.Data.Ecommerce.Context
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext()
        { }
        public EcommerceContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        protected override void OnConfiguring(DbContextOptions options)
        {
            //options.UseSqlServer(@"Server=LEVTIN-PC;Database=AnB;integrated security=True;");
            options.UseSqlServer();
        }
    }
}