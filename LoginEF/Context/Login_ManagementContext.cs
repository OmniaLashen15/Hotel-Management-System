using LoginEF.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginEF.Context
{
    public class Login_ManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source = .;Initial Catalog=Login_Management_New;Integrated Security=true;");

        public virtual DbSet<Frontend> FrontEnds { get; set; }
        public virtual DbSet<Kitchen> Kitchen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FrontConfiguration());
            modelBuilder.ApplyConfiguration(new KitchenConfiguration());


            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = from e in ChangeTracker.Entries()
                          where e.State == EntityState.Modified || e.State == EntityState.Added
                          select e;
            foreach (var entry in entries)
            {
                var validatorcontext = new ValidationContext(entry.Entity);
                Validator.ValidateObject(entry.Entity, validatorcontext, true);
            }
            return base.SaveChanges();
        }
    }
    
}
