namespace COMP1004_Assignment4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputerContext : DbContext
    {
        public ComputerContext()
            : base("name=ComputerContext")
        {
        }

        public virtual DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
