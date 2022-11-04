using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // DbContext, DbContextOptionsBuilder

namespace WorkingWithEFCore
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                Data Source =DESKTOP-K7T8JGL; 
                Initial Catalog=Northwind;
                Integrated Security=true;
                MultipleActiveResultSets=true;
            ");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // example of using Fluent API instead of attributes
            // to limit the length of a category name to 15
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()// NOT NULL
                .HasMaxLength(15);
            if(ProjectConstants.DatabaseProvider == "SQLite")
            {
                // added to "fix" the lack of decimal support in SQLite
                modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();
            }
        }
    }
}
