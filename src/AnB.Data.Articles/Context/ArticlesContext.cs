using AnB.Data.Articles.Models;
using Microsoft.Data.Entity;
using System;

namespace AnB.Data.Articles.Context
{
    public class ArticlesContext :DbContext
    {
        public ArticlesContext()
        { }
        public ArticlesContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<Models.Articles> Articles { get; set; }
        public DbSet<Articles_Content> Articles_Content { get; set; }
        protected override void OnConfiguring(DbContextOptions options)
        {
            //options.UseSqlServer(@"Server=LEVTIN-PC;Database=AnB;integrated security=True;");
            options.UseSqlServer();
        }
    }
}