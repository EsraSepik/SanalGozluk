using Microsoft.EntityFrameworkCore;
using SanalGozluk.Models;

namespace SanalGozluk.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Gozluk> Gozlukler { get; set; }
    }
}