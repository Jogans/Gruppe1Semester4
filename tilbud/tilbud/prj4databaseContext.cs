using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace tilbud
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
        public virtual DbSet<IngredientList> IngredientList { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<NyVare> NyVare { get; set; }
        public virtual DbSet<Opskrift> Opskrift { get; set; }
        public virtual DbSet<OpskriftKategori> OpskriftKategori { get; set; }
        public virtual DbSet<PrefsCategories> PrefsCategories { get; set; }
        public virtual DbSet<PrefsChains> PrefsChains { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<RetailChains> RetailChains { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
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
                    .HasName("PK__Abningst__363950E8919206B7");

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
                    .HasConstraintName("FK__Abningsti__butik__0169315C");
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
                    .HasConstraintName("FK__Butik__vareID__7E8CC4B1");
            });

            modelBuilder.Entity<IngredientList>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__ingredie__B0E453CF81168D6F");

                entity.ToTable("ingredient_list");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountUnit)
                    .HasColumnName("amount_unit")
                    .HasMaxLength(255);

                entity.Property(e => e.IngredientName)
                    .IsRequired()
                    .HasColumnName("ingredient_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductRef).HasColumnName("product_ref");

                entity.Property(e => e.Recipe).HasColumnName("recipe");

                entity.HasOne(d => d.ProductRefNavigation)
                    .WithMany(p => p.IngredientList)
                    .HasForeignKey(d => d.ProductRef)
                    .HasConstraintName("FK_ingredients_products");

                entity.HasOne(d => d.RecipeNavigation)
                    .WithMany(p => p.IngredientList)
                    .HasForeignKey(d => d.Recipe)
                    .HasConstraintName("FK_ingredients_recipe");
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.HasKey(e => e.Kategori1)
                    .HasName("PK__Kategori__BFBCD944A90B6363");

                entity.Property(e => e.Kategori1)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<NyVare>(entity =>
            {
                entity.HasKey(e => e.VareId)
                    .HasName("PK__NyVare__0A039BF9D46E6C18");

                entity.Property(e => e.VareId).HasColumnName("vareID");

                entity.Property(e => e.Butik)
                    .HasColumnName("butik")
                    .HasMaxLength(50)
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
                    .HasName("PK__Opskrift__869396F90FA7D6C1");

                entity.Property(e => e.OpskriftId).HasColumnName("opskriftID");

                entity.Property(e => e.Kategori)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KategoriNavigation)
                    .WithMany(p => p.OpskriftKategori)
                    .HasForeignKey(d => d.Kategori)
                    .HasConstraintName("FK__OpskriftK__kateg__7BB05806");

                entity.HasOne(d => d.Opskrift)
                    .WithMany(p => p.OpskriftKategori)
                    .HasForeignKey(d => d.OpskriftId)
                    .HasConstraintName("FK__OpskriftK__opskr__7ABC33CD");
            });

            modelBuilder.Entity<PrefsCategories>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Category })
                    .HasName("PK_prefs_cat");

                entity.ToTable("prefs_categories");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(255);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PrefsCategories)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pref_cat_username");
            });

            modelBuilder.Entity<PrefsChains>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.RetailChain });

                entity.ToTable("prefs_chains");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.Property(e => e.RetailChain)
                    .HasColumnName("retail_chain")
                    .HasMaxLength(255);

                entity.HasOne(d => d.RetailChainNavigation)
                    .WithMany(p => p.PrefsChains)
                    .HasForeignKey(d => d.RetailChain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prefs_chains_chains");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PrefsChains)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_prefs_chains_username");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__products__47027DF5D8A01FFD");

                entity.ToTable("products");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AmountUnit)
                    .IsRequired()
                    .HasColumnName("amount_unit")
                    .HasMaxLength(255);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PricePrAmount)
                    .HasColumnName("price_pr_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceRegular)
                    .HasColumnName("price_regular")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceSale)
                    .HasColumnName("price_sale")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RetailChain)
                    .IsRequired()
                    .HasColumnName("retail_chain")
                    .HasMaxLength(255);

                entity.Property(e => e.SavingsAbsolute)
                    .HasColumnName("savings_absolute")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SavingsPercent)
                    .HasColumnName("savings_percent")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RetailChainNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.RetailChain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_product_chain");
            });

            modelBuilder.Entity<Recipes>(entity =>
            {
                entity.HasKey(e => e.RecipeId)
                    .HasName("PK__recipes__3571ED9B43F6CF7A");

                entity.ToTable("recipes");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(255);

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

                entity.Property(e => e.SavingsPercent)
                    .HasColumnName("savings_percent")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Servings).HasColumnName("servings");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RetailChains>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__retail_c__72E12F1ADAE2682D");

                entity.ToTable("retail_chains");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__stores__A2F2A30C987F6792");

                entity.ToTable("stores");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Hours)
                    .HasColumnName("hours")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.RetailChain)
                    .IsRequired()
                    .HasColumnName("retail_chain")
                    .HasMaxLength(255);

                entity.HasOne(d => d.RetailChainNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.RetailChain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stores_chains");
            });

            modelBuilder.Entity<Subscriptions>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Recipe });

                entity.ToTable("subscriptions");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.Property(e => e.Recipe).HasColumnName("recipe");

                entity.Property(e => e.MaxPrice)
                    .HasColumnName("max_price")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.RecipeNavigation)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.Recipe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sub_recipe");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sub_username");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__users__F3DBC5730B0BB81D");

                entity.ToTable("users");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);
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
                    .HasName("PK__VareKate__51F8566D18214137");

                entity.Property(e => e.VareId).HasColumnName("vareID");

                entity.Property(e => e.Kategori)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KategoriNavigation)
                    .WithMany(p => p.VareKategori)
                    .HasForeignKey(d => d.Kategori)
                    .HasConstraintName("FK__VareKateg__kateg__75F77EB0");

                entity.HasOne(d => d.Vare)
                    .WithMany(p => p.VareKategori)
                    .HasForeignKey(d => d.VareId)
                    .HasConstraintName("FK__VareKateg__vareI__75035A77");
            });
        }
    }
}
