using Microsoft.EntityFrameworkCore;
using Z509.Models;

namespace Z509
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FilmDBZ509;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbContextOptions.UseSqlServer(cs);
        }
    }
}
