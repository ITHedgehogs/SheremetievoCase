using Microsoft.EntityFrameworkCore;
using SheremetievoRent.Server.Converters;
using SheremetievoRent.Shared;

namespace SheremetievoRent.Server.Data
{
    public sealed class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var stringValueConverter = new StringListToStringValueConverter();

            modelBuilder
                .Entity<User>()
                .Property(e => e.BaseDeals)
                .HasConversion(stringValueConverter);
        }
    }
}