using FilmDB.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB.Context
{
    public class FilmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = @"Data Source=grzegorz-7m1f\SQLEXPRESS;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(cs);
        }

        public DbSet<FilmModel> Films { get; set; }
    }
}
