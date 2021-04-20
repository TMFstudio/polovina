﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AssignNeedyToPlans.Model
{
    public partial class Contexts : DbContext
    {
        public Contexts()
        {
        }

        public Contexts(DbContextOptions<Contexts> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAssignNeedyToPlan> TblAssignNeedyToPlans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9Q51Q00\\TMF;Database=DataModelSection;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<TblAssignNeedyToPlan>(entity =>
            {
                entity.Property(e => e.AssignNeedyPlanId).ValueGeneratedNever();

                entity.Property(e => e.Fdate).IsUnicode(false);

                entity.Property(e => e.Tdate).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
