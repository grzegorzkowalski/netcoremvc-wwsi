using FilmBD503.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmBD503.Contexts
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=DESKTOP-55KJ8EL\SQLEXPRESS;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbContextOptions.UseSqlServer(cs);
        }
    }
}
