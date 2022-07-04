using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class DomContextcs : DbContext
    {
        public DbSet<Domeniu> Domenii { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dom.db");
        }

        // public DbSet<Articol> articole { get; set; }
        public DomContextcs()
            {
            try
            {
                Database.Migrate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
}
