using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Smartsolutions.Domain.Entities;

namespace Smartsolutions.Infrastructure.Persistence
{
    internal class SmartsolutionsDbContext(DbContextOptions<SmartsolutionsDbContext> options) : DbContext(options)
    {
        internal DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.OwnsOne(u => u.address, address =>
                {
                    address.Property(a => a.Country).HasColumnName("Country");
                    address.Property(a => a.City).HasColumnName("City");
                    address.Property(a => a.PostalCode).HasColumnName("PostalCode");
                });
            });
        }
    }
}
