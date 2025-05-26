using Microsoft.EntityFrameworkCore;
using f1Core.Models;

namespace f1Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Race> Races => Set<Race>();
        public DbSet<Circuit> Circuits => Set<Circuit>();
        public DbSet<Driver> Drivers => Set<Driver>();
        public DbSet<Constructor> Constructors => Set<Constructor>();
        public DbSet<Season> Seasons => Set<Season>();
        public DbSet<Result> Results => Set<Result>();
        public DbSet<DriverStanding> DriverStandings => Set<DriverStanding>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 可設定複合主鍵、關聯等
        }
    }
}
