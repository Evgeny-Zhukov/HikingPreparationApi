using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.DbContext
{
    public class HikingDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public HikingDbContext(DbContextOptions<HikingDbContext> options) : base(options) { }

        public DbSet<User> Users;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
