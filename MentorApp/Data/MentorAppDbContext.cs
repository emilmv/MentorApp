using MentorApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace MentorApp.Data
{
    public class MentorAppDbContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingService> PricingServices { get; set; }
        public MentorAppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
