using Microsoft.EntityFrameworkCore;

namespace API_Practice.Data
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext>options) : base(options)
        {                                                       
               
        }

        public DbSet<Book> Books { get; set; }

       // public DbSet<Price> Prices { get; set; }
    }
}
