using Microsoft.EntityFrameworkCore;
using Z502.Models;

namespace Z502
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FilmlDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(cs);
        }
    }
}
