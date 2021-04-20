using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CommonBaseType.Model
{
    public partial class BaseType_Context : DbContext
    {
        public BaseType_Context()
        {
        }

        public BaseType_Context(DbContextOptions<BaseType_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCommonBaseType> TblCommonBaseTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(local);Database=Charity_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<TblCommonBaseType>(entity =>
            {
                entity.Property(e => e.BaseTypeCode).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
