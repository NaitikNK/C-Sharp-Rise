using CouponCode.model;
using Microsoft.EntityFrameworkCore;


namespace CouponCode.context
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        public DbSet<coupenDb> CoupenDbs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<coupenDb>().ToTable("coupen");
            modelBuilder.Entity<Notification>().ToTable("notification");
        }
    }
}
