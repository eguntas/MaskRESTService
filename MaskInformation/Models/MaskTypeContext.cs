using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MaskInformation.Models
{
    public partial class MaskTypeContext : DbContext
    {
        public MaskTypeContext()
        {
        }

        public MaskTypeContext(DbContextOptions<MaskTypeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Maske> Maske { get; set; }
        public virtual DbSet<MaskeBkp> MaskeBkp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.30.0.164;Database=MaskType;user=sa;password=Qu1nt1q!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Maske>(entity =>
            {
                entity.Property(e => e.Ambalaj).HasMaxLength(25);

                entity.Property(e => e.Barkod).HasMaxLength(25);

                entity.Property(e => e.Boyut).HasMaxLength(25);

                entity.Property(e => e.Dil).HasMaxLength(25);

                entity.Property(e => e.Kategori).HasMaxLength(50);

                entity.Property(e => e.Koli).HasMaxLength(25);

                entity.Property(e => e.Kutu).HasMaxLength(25);

                entity.Property(e => e.Renk).HasMaxLength(25);

                entity.Property(e => e.Tip).HasMaxLength(25);
            });

            modelBuilder.Entity<MaskeBkp>(entity =>
            {
                entity.ToTable("Maske_bkp");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ambalaj).HasMaxLength(25);

                entity.Property(e => e.Barkod).HasMaxLength(25);

                entity.Property(e => e.Boyut).HasMaxLength(25);

                entity.Property(e => e.Dil).HasMaxLength(25);

                entity.Property(e => e.Kategori).HasMaxLength(50);

                entity.Property(e => e.Koli).HasMaxLength(25);

                entity.Property(e => e.Kutu).HasMaxLength(25);

                entity.Property(e => e.Renk).HasMaxLength(25);

                entity.Property(e => e.Tip).HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
