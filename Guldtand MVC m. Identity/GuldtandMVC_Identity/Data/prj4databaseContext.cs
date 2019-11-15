using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GuldtandMVC_Identity.Data
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

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientList> IngredientList { get; set; }
        public virtual DbSet<OpenHours> OpenHours { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategory { get; set; }
        public virtual DbSet<RetailChain> RetailChain { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=prj4-server.database.windows.net;Initial Catalog=prj4-database;User ID=rasmus;Password=8AmT7#l&e&q$;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryName)
                    .HasName("PK__category__5189E254E3CC7E3E");

                entity.ToTable("category");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("ingredient");

                entity.HasIndex(e => e.ProductId)
                    .HasName("UQ__ingredie__47027DF4D92C716C")
                    .IsUnique();

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountUnit)
                    .HasColumnName("amount_unit")
                    .HasMaxLength(15);

                entity.Property(e => e.IngredientListId).HasColumnName("ingredientList_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.IngredientList)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.IngredientListId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ingredien__ingre__226AFDCB");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.Ingredient)
                    .HasForeignKey<Ingredient>(d => d.ProductId)
                    .HasConstraintName("FK__ingredien__produ__2176D992");
            });

            modelBuilder.Entity<IngredientList>(entity =>
            {
                entity.ToTable("ingredientList");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("UQ__ingredie__3571ED9A52106FCC")
                    .IsUnique();

                entity.Property(e => e.IngredientListId).HasColumnName("ingredientList_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.HasOne(d => d.Recipe)
                    .WithOne(p => p.IngredientList)
                    .HasForeignKey<IngredientList>(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ingredien__recip__1DA648AE");
            });

            modelBuilder.Entity<OpenHours>(entity =>
            {
                entity.HasKey(e => e.DayOfWeek)
                    .HasName("PK__open_hou__869EECA81B05055C");

                entity.ToTable("open_hours");

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("day_of_week")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.OpenFrom).HasColumnName("open_from");

                entity.Property(e => e.OpenTo).HasColumnName("open_to");

                entity.Property(e => e.RetailChainId).HasColumnName("retail_chain_id");

                entity.HasOne(d => d.RetailChain)
                    .WithMany(p => p.OpenHours)
                    .HasForeignKey(d => d.RetailChainId)
                    .HasConstraintName("FK__open_hour__retai__0A93743A");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasIndex(e => e.RetailChainId)
                    .HasName("UQ__product__605B07AA157BDF3A")
                    .IsUnique();

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ImgSrc)
                    .HasColumnName("img_src")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RetailChainId).HasColumnName("retail_chain_id");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("valid_from")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("valid_to")
                    .HasColumnType("datetime");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.Property(e => e.VolumePrice).HasColumnName("volume_price");

                entity.HasOne(d => d.RetailChain)
                    .WithOne(p => p.Product)
                    .HasForeignKey<Product>(d => d.RetailChainId)
                    .HasConstraintName("FK__product__retail___104C4D90");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryName })
                    .HasName("PK__product___121AE3D0C095018B");

                entity.ToTable("product_category");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CategoryNameNavigation)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.CategoryName)
                    .HasConstraintName("FK__product_c__categ__160526E6");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__product_c__produ__151102AD");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("recipe");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.Directions)
                    .IsRequired()
                    .HasColumnName("directions")
                    .HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SavingsAbsolute).HasColumnName("savings_absolute");

                entity.Property(e => e.Servings).HasColumnName("servings");
            });

            modelBuilder.Entity<RecipeCategory>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.CategoryName })
                    .HasName("PK__recipe_c__606973BE4732D3C2");

                entity.ToTable("recipe_category");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CategoryNameNavigation)
                    .WithMany(p => p.RecipeCategory)
                    .HasForeignKey(d => d.CategoryName)
                    .HasConstraintName("FK__recipe_ca__categ__19D5B7CA");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeCategory)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__recipe_ca__recip__18E19391");
            });

            modelBuilder.Entity<RetailChain>(entity =>
            {
                entity.ToTable("retail_chain");

                entity.Property(e => e.RetailChainId).HasColumnName("retail_chain_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });
        }
    }
}
