using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MovieCoreDBContext : DbContext
    {
        public MovieCoreDBContext()
        { }
        public MovieCoreDBContext(DbContextOptions<MovieCoreDBContext> options)
            : base(options)
        { }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Person> Person { get; set; }
    }
}
