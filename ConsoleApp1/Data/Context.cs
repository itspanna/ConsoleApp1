using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.class1;

namespace ConsoleApp1.Data
{
    internal class Context : DbContext
    {
        public DbSet <Name> Name { get; set; }
        public DbSet <age> age { get; set; }
        public DbSet <orszag> orszag { get; set; }
        public DbSet <szak> szak { get; set; }
        public DbSet <hobbi> hobbi { get; set; }

        public Context(DbContextOptions<Context> options) : base(options);
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}   


