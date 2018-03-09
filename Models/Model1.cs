namespace practice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2> Table2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table1>()
                .Property(e => e.car)
                .IsUnicode(false);

            modelBuilder.Entity<Table1>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<Table2>()
                .Property(e => e.brand)
                .IsUnicode(false);
        }
    }
}
