using FilmDB.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB.Contexts
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=DESKTOP-55KJ8EL\SQLEXPRESS;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbContextOptions.UseSqlServer(cs);
        }
    }
}
