namespace MyCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CodeFirst : DbContext
    {
        public CodeFirst()
            : base("name=CodeFirst")
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<DriveUnit> DriveUnit { get; set; }
        public virtual DbSet<Engine> Engine { get; set; }
        public virtual DbSet<ImagesCar> ImagesCar { get; set; }
        public virtual DbSet<Mark> Mark { get; set; }
        public virtual DbSet<NewsCar> NewsCar { get; set; }
        public virtual DbSet<TypesCarBodies> TypesCarBodies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DriveUnit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Engine>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Mark>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<NewsCar>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TypesCarBodies>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
