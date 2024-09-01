using Microsoft.EntityFrameworkCore;
using MinimalAPI.Domain.Entities;

namespace MinimalAPI.Infrastructure.Db
{
    public class DbCarContext : DbContext
    {
        public DbCarContext(DbContextOptions<DbCarContext> options) : base(options)
        {
        }

        public DbSet<Administrator> Administrators { get; set; } = default!;
        public DbSet<Car> Cars { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().HasData(
                new Administrator
                {
                    Id = "1",
                    Email = "adm@test.com",
                    Password = "123456",
                    Profile = "Adm"
                });
        }
    }
}