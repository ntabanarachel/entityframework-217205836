using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    public class MovieContext : DbContext
    {
        public DbSet<Movietbl> Moviess { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStartted.MoviessApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Movietbl
    {  
        [Key]
        public int MovieId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}