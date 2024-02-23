using Microsoft.EntityFrameworkCore;
using SSLVigil.Models;

namespace SSLVigil.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ApplicationSettings> ApplicationSettings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
