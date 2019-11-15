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

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientIngredientlist> IngredientIngredientlist { get; set; }
        public virtual DbSet<Ingredientlist> Ingredientlist { get; set; }
        public virtual DbSet<Openhours> Openhours { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategory { get; set; }
        public virtual DbSet<RecipeIngredientlist> RecipeIngredientlist { get; set; }
        public virtual DbSet<RetailChain> RetailChain { get; set; }

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

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryName)
                    .HasName("PK__category__5189E25446E73892");

                entity.ToTable("category");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("ingredient");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountUnit)
                    .HasColumnName("amount_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Product).HasColumnName("product");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.Product)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ingredien__produ__324C5FD9");
            });

            modelBuilder.Entity<IngredientIngredientlist>(entity =>
            {
                entity.HasKey(e => new { e.IngredientId, e.IngredientlistId })
                    .HasName("PK__ingredie__ADB7880B911C972F");

                entity.ToTable("ingredient_ingredientlist");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.IngredientlistId).HasColumnName("ingredientlist_id");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.IngredientIngredientlist)
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK__ingredien__ingre__418EA369");

                entity.HasOne(d => d.Ingredientlist)
                    .WithMany(p => p.IngredientIngredientlist)
                    .HasForeignKey(d => d.IngredientlistId)
                    .HasConstraintName("FK__ingredien__ingre__4282C7A2");
            });

            modelBuilder.Entity<Ingredientlist>(entity =>
            {
                entity.ToTable("ingredientlist");

                entity.Property(e => e.IngredientlistId).HasColumnName("ingredientlist_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.Ingredientlist)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_ingredients_recipe");
            });

            modelBuilder.Entity<Openhours>(entity =>
            {
                entity.HasKey(e => e.DayOfWeek)
                    .HasName("PK__openhour__869EECA877494DDB");

                entity.ToTable("openhours");

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("day_of_week")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.OpenFrom).HasColumnName("open_from");

                entity.Property(e => e.OpenTo).HasColumnName("open_to");

                entity.Property(e => e.RetailChainId).HasColumnName("retail_chain_id");

                entity.HasOne(d => d.RetailChain)
                    .WithMany(p => p.Openhours)
                    .HasForeignKey(d => d.RetailChainId)
                    .HasConstraintName("FK__openhours__retai__2AAB3E11");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ImgSrc)
                    .HasColumnName("img_src")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RetailChainId).HasColumnName("retail_chain_id");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("valid_from")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("valid_to")
                    .HasColumnType("datetime");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VolumePrice)
                    .HasColumnName("volume_price")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.RetailChain)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.RetailChainId)
                    .HasConstraintName("FK_product_chain");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryName })
                    .HasName("PK__product___121AE3D07537406F");

                entity.ToTable("product_Category");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CategoryNameNavigation)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.CategoryName)
                    .HasConstraintName("FK__product_C__categ__3805392F");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategory)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__product_C__produ__371114F6");
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

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SavingsAbsolute)
                    .HasColumnName("savings_absolute")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Servings).HasColumnName("servings");
            });

            modelBuilder.Entity<RecipeCategory>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.CategoryName })
                    .HasName("PK__recipe_C__606973BE5CE52DDC");

                entity.ToTable("recipe_Category");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CategoryNameNavigation)
                    .WithMany(p => p.RecipeCategory)
                    .HasForeignKey(d => d.CategoryName)
                    .HasConstraintName("FK__recipe_Ca__categ__3BD5CA13");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeCategory)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK__recipe_Ca__recip__3AE1A5DA");
            });

            modelBuilder.Entity<RecipeIngredientlist>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.IngredientlistId })
                    .HasName("PK__recipe_i__2822365FC8BD81EA");

                entity.ToTable("recipe_ingredientlist");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.IngredientlistId).HasColumnName("ingredientlist_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountUnit)
                    .IsRequired()
                    .HasColumnName("amount_unit")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Ingredientlist)
                    .WithMany(p => p.RecipeIngredientlist)
                    .HasForeignKey(d => d.IngredientlistId)
                    .HasConstraintName("FK__recipe_in__ingre__46535886");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeIngredientlist)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK__recipe_in__recip__455F344D");
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
