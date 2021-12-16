using Microsoft.EntityFrameworkCore;
using StarkFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarkFamily.Data
{
    public class FamilyContext : DbContext
    {
        public FamilyContext(DbContextOptions<FamilyContext> options) : base(options)
        {
        }

        public DbSet<Person> Personos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>()
            .HasOne(a => a.Mother)
            .WithMany(a => a.MotherChildren)
            .HasForeignKey(a => a.MotherId);

            modelBuilder.Entity<Person>()
            .HasOne(a => a.Father)
            .WithMany(a => a.FatherChildren)
            .HasForeignKey(a => a.FatherId);
        
        modelBuilder.Entity<Person>().ToTable("Persons");
        }
    }
}
