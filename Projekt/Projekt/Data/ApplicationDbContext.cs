using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekt.Models;

namespace Projekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Projekt.Models.Client>? Client { get; set; }
        public DbSet<Projekt.Models.Insurance>? Insurance { get; set; }
    }
}