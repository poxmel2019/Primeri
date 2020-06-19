using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace primeri
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext()
        { 
           Database.EnsureCreated();
        }

        public DbSet<UsersStatics> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=userstappdb;Trusted_Connection=True;");
            
        }
    }
}
