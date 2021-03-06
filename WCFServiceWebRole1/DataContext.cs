namespace WCFServiceWebRole1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext3")
        {
        }

        public virtual DbSet<Bevaegelser> Bevaegelser { get; set; }
        public virtual DbSet<Brugere> Brugere { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bevaegelser>()
                .Property(e => e.Temperatur)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Brugere>()
                .Property(e => e.Brugernavn)
                .IsUnicode(false);

            modelBuilder.Entity<Brugere>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Brugere>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
