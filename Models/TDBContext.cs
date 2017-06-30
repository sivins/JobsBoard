using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using reverseJobsBoard.Models;
using reverseJobsBoard.Config;

namespace reverseJobsBoard.Models
{
    public class TDBContext : DbContext
    {
        //Example
        public DbSet<User> Users { get; set; }
    
        //For migrations you have to specify many to many relationships here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            TestConfigs config = new TestConfigs();
            optionsBuilder.UseSqlServer(@config.testDBUrl);
        }
    }

}