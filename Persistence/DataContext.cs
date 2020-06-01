using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
             
        }

        public DbSet<Value> Values {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value {id = 1, Name = "101"},
                new Value {id = 2, Name = "102"},
                new Value {id = 3, Name = "103"},
                new Value {id = 4, Name = "104"},
                new Value {id = 5, Name = "105"}
            );
        }
    }
}
