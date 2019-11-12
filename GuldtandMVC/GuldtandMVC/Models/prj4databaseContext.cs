using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GuldtandMVC.Models
{
    public partial class prj4databaseContext : DbContext
    {
        public prj4databaseContext()
        {
        }

        public prj4databaseContext(DbContextOptions<prj4databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abningstid> Abningstid { get; set; }
        public virtual DbSet<Butik> Butik { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<NyVare> NyVare { get; set; }
        public virtual DbSet<Opskrift> Opskrift { get; set; }
        public virtual DbSet<OpskriftKategori> OpskriftKategori { get; set; }
        public virtual DbSet<Vare> Vare { get; set; }
        public virtual DbSet<VareKategori> VareKategori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=prj4-server.database.windows.net;Initial Catalog=prj4-database;User ID=martin;Password=sY0$*68y!N0v");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Abningstid>(entity =>
            {
                entity.HasKey(e => e.Ugedag)
                    .HasName("PK__Abningst__363950E8F57F7389");

                entity.Property(e => e.Ugedag)
                    .HasColumnName("ugedag")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AbenFra).HasColumnName("aben_fra");

                entity.Property(e => e.AbenTil).HasColumnName("aben_til");

                entity.Property(e => e.ButikId).HasColumnName("butik_id");

                entity.HasOne(d => d.Butik)
                    .WithMany(p => p.Abningstid)
                    .HasForeignKey(d => d.ButikId)
                    .HasConstraintName("FK__Abningsti__butik__0C70CFB4");
            });

            modelBuilder.Entity<Butik>(entity =>
            {
                entity.Property(e => e.ButikId).HasColumnName("butikID");

                entity.Property(e => e.Addresse)
                    .IsRequired()
                    .HasColumnName("addresse")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Butiknavn)
                    .IsRequired()
                    .HasColumnName("butiknavn")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VareId).HasColumnName("vareID");

                entity.HasOne(d => d.Vare)
                    .WithMany(p => p.ButikNavigation)
                    .HasForeignKey(d => d.VareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Butik__vareID__09946309");
            });

            

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.HasKey(e => e.Kategori1)
                    .HasName("PK__Kategori__BFBCD94401F34AC9");

                entity.Property(e => e.Kategori1)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<NyVare>(entity =>
            {
                entity.HasKey(e => e.VareId)
                    .HasName("PK__NyVare__0A039BF99CA62479");

                entity.Property(e => e.VareId).HasColumnName("vareID");

                entity.Property(e => e.Butik)
                    .HasColumnName("butik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgSrc)
                    .HasColumnName("img_src")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Navn)
                    .HasColumnName("navn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pris).HasColumnName("pris");

                entity.Property(e => e.ValidFra)
                    .HasColumnName("valid_fra")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTil)
                    .HasColumnName("valid_til")
                    .HasColumnType("datetime");

                entity.Property(e => e.Volumen).HasColumnName("volumen");

                entity.Property(e => e.Volumenpris).HasColumnName("volumenpris");
            });

            modelBuilder.Entity<Opskrift>(entity =>
            {
                entity.Property(e => e.OpskriftId).HasColumnName("opskriftID");

                entity.Property(e => e.Beskrivelse)
                    .IsRequired()
                    .HasColumnName("beskrivelse")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Besparelse).HasColumnName("besparelse");

                entity.Property(e => e.Navn)
                    .IsRequired()
                    .HasColumnName("navn")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pris).HasColumnName("pris");
            });

            modelBuilder.Entity<OpskriftKategori>(entity =>
            {
                entity.HasKey(e => new { e.OpskriftId, e.Kategori })
                    .HasName("PK__Opskrift__869396F91D4CBD8D");

                entity.Property(e => e.OpskriftId).HasColumnName("opskriftID");

                entity.Property(e => e.Kategori)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KategoriNavigation)
                    .WithMany(p => p.OpskriftKategori)
                    .HasForeignKey(d => d.Kategori)
                    .HasConstraintName("FK__OpskriftK__kateg__06B7F65E");

                entity.HasOne(d => d.Opskrift)
                    .WithMany(p => p.OpskriftKategori)
                    .HasForeignKey(d => d.OpskriftId)
                    .HasConstraintName("FK__OpskriftK__opskr__05C3D225");
            });

            

            modelBuilder.Entity<Vare>(entity =>
            {
                entity.Property(e => e.VareId).HasColumnName("vareID");

                entity.Property(e => e.Butik)
                    .HasColumnName("butik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Imgsrc)
                    .HasColumnName("imgsrc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Navn)
                    .HasColumnName("navn")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pris).HasColumnName("pris");

                entity.Property(e => e.ValidFra)
                    .HasColumnName("valid_fra")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTil)
                    .HasColumnName("valid_til")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Volumen).HasColumnName("volumen");

                entity.Property(e => e.Volumenpris).HasColumnName("volumenpris");
            });

            modelBuilder.Entity<VareKategori>(entity =>
            {
                entity.HasKey(e => new { e.VareId, e.Kategori })
                    .HasName("PK__VareKate__51F8566D62A76F18");

                entity.Property(e => e.VareId).HasColumnName("vareID");

                entity.Property(e => e.Kategori)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KategoriNavigation)
                    .WithMany(p => p.VareKategori)
                    .HasForeignKey(d => d.Kategori)
                    .HasConstraintName("FK__VareKateg__kateg__00FF1D08");

                entity.HasOne(d => d.Vare)
                    .WithMany(p => p.VareKategori)
                    .HasForeignKey(d => d.VareId)
                    .HasConstraintName("FK__VareKateg__vareI__000AF8CF");
            });
        }
    }
}
