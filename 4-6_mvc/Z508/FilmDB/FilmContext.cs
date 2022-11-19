using FilmDB.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(cs);
        }
    }
}
