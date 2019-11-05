using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace tilbud
{
    public partial class projtestContext : DbContext
    {
        public projtestContext()
        {
        }

        public projtestContext(DbContextOptions<projtestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tabel> Tabel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=projtest;Data Source=DESKTOP-0FHV6SU\\MSSQLSERVER2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Tabel>(entity =>
            {
                entity.ToTable("tabel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tekst)
                    .HasColumnName("tekst")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
