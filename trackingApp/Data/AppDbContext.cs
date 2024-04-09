using Microsoft.EntityFrameworkCore;
using trackingApp.Models;

namespace trackingApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Appointment> Appointemnts { get; set; }
    }
}
