using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApi.Models;

namespace webApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=db16109.databaseasp.net; Database=db16109; User Id=db16109; Password=C%o2g4?JHh5#; Encrypt=False; MultipleActiveResultSets=True; TrustServerCertificate=True");
            }
        }
        public DbSet<Product> Products { get; set; }
    }
}