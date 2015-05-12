using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System;

namespace AnB.Site.Models
{
    public class ApplicationUser : IdentityUser { }
    public class SiteDbContext : DbContext
    {        
        public DbSet<Category> Category { get; set; }
        
    }
}