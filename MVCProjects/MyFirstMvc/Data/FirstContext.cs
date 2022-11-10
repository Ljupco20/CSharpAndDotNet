
using Microsoft.EntityFrameworkCore;
using MyFirstMvc.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstMvc.Data
{
    public class FirstContext : DbContext
    {
        public FirstContext(DbContextOptions options) : base(options)
        {

        }
      
        public DbSet<Person> People { get; set; }
        public DbSet<PersonDetails> PersonDetails { get; set; }

    }
}
