using FirstDbProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDbProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server = (localdb)\\MSSQLLocalDB; " +
                "Database = StudyCenterDB; ";

            optionsBuilder.UseSqlServer(path);
        }
    }
}
