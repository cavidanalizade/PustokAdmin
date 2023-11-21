using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.DAL
{
    public class AppDBC:DbContext
    {
        public AppDBC(DbContextOptions<AppDBC> options):base(options)
        {

        }

        public DbSet<Slider> sliders { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<BookImage> bookImages { get; set; }
        public DbSet<Category> categories { get; set; }



    }
}
