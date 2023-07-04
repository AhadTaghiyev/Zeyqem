using ArshaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArshaApp.Context
{
    public class ArshaAppDbContext:DbContext
    {
        public DbSet<Info> Infos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Service> Services { get; set; }

        public ArshaAppDbContext(DbContextOptions<ArshaAppDbContext>options):base(options)
        {

        }
    }
}
