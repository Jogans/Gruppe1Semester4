﻿// <auto-generated />
using System;
using GuldtandMVC_Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuldtandMVC_Identity.Migrations
{
    [DbContext(typeof(prj4databaseContext))]
    partial class prj4databaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GuldtandMVC_Identity.Blacklist", b =>
                {
                    b.Property<string>("Category")
                        .HasColumnName("category")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("Category")
                        .HasName("PK__blacklis__F7F53CC351A434DF");

                    b.ToTable("blacklist");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Category", b =>
                {
                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name")
                        .HasMaxLength(50);

                    b.HasKey("CategoryName")
                        .HasName("PK__category__5189E254535378E8");

                    b.ToTable("category");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Directions", b =>
                {
                    b.Property<int>("DirectionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("directions_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasMaxLength(255);

                    b.Property<int>("RecipeId")
                        .HasColumnName("recipe_id");

                    b.HasKey("DirectionsId");

                    b.HasIndex("RecipeId");

                    b.ToTable("directions");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ingredient_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Amount")
                        .HasColumnName("amount");

                    b.Property<string>("AmountUnit")
                        .HasColumnName("amount_unit")
                        .HasMaxLength(15);

                    b.Property<int?>("IngredientListId")
                        .HasColumnName("ingredientList_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.Property<int?>("ProductId")
                        .HasColumnName("product_id");

                    b.HasKey("IngredientId");

                    b.HasIndex("IngredientListId");

                    b.HasIndex("Name");

                    b.HasIndex("ProductId");

                    b.ToTable("ingredient");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.IngredientList", b =>
                {
                    b.Property<int>("IngredientListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ingredientList_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RecipeId")
                        .HasColumnName("recipe_id");

                    b.HasKey("IngredientListId");

                    b.HasIndex("RecipeId")
                        .IsUnique()
                        .HasName("UQ__ingredie__3571ED9A29CD80B9")
                        .HasFilter("[recipe_id] IS NOT NULL");

                    b.ToTable("ingredientList");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.OpenHours", b =>
                {
                    b.Property<string>("DayOfWeek")
                        .HasColumnName("day_of_week")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<TimeSpan?>("OpenFrom")
                        .HasColumnName("open_from");

                    b.Property<TimeSpan?>("OpenTo")
                        .HasColumnName("open_to");

                    b.Property<int>("RetailChainId")
                        .HasColumnName("retail_chain_id");

                    b.HasKey("DayOfWeek")
                        .HasName("PK__open_hou__869EECA867AD9B20");

                    b.HasIndex("RetailChainId");

                    b.ToTable("open_hours");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("product_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgSrc")
                        .HasColumnName("img_src")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnName("price");

                    b.Property<int?>("RetailChainId")
                        .HasColumnName("retail_chain_id");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnName("valid_from")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnName("valid_to")
                        .HasColumnType("datetime");

                    b.Property<double>("Volume")
                        .HasColumnName("volume");

                    b.Property<double?>("VolumePrice")
                        .HasColumnName("volume_price");

                    b.HasKey("ProductId");

                    b.HasIndex("RetailChainId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name")
                        .HasMaxLength(50);

                    b.HasKey("ProductId", "CategoryName")
                        .HasName("PK__product___121AE3D0B94E8F57");

                    b.HasIndex("CategoryName");

                    b.ToTable("product_category");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recipe_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CookTime")
                        .HasColumnName("cook_time");

                    b.Property<string>("ImgSrc")
                        .HasColumnName("img_src")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.Property<double?>("Price")
                        .HasColumnName("price");

                    b.Property<double?>("SavingsAbsolute")
                        .HasColumnName("savings_absolute");

                    b.Property<int?>("Servings")
                        .HasColumnName("servings");

                    b.HasKey("RecipeId");

                    b.ToTable("recipe");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.RecipeCategory", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnName("recipe_id");

                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name")
                        .HasMaxLength(50);

                    b.HasKey("RecipeId", "CategoryName")
                        .HasName("PK__recipe_c__606973BEB82D8C04");

                    b.HasIndex("CategoryName");

                    b.ToTable("recipe_category");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.RetailChain", b =>
                {
                    b.Property<int>("RetailChainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("retail_chain_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("RetailChainId");

                    b.ToTable("retail_chain");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Directions", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.Recipe", "Recipe")
                        .WithMany("Directions")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__direction__recip__67152DD3")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Ingredient", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.IngredientList", "IngredientList")
                        .WithMany("Ingredient")
                        .HasForeignKey("IngredientListId")
                        .HasConstraintName("FK__ingredien__ingre__60683044")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GuldtandMVC_Identity.Category", "NameNavigation")
                        .WithMany("Ingredient")
                        .HasForeignKey("Name")
                        .HasConstraintName("FK_CategoryName");

                    b.HasOne("GuldtandMVC_Identity.Product", "Product")
                        .WithMany("Ingredient")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__ingredien__produ__5F740C0B");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.IngredientList", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.Recipe", "Recipe")
                        .WithOne("IngredientList")
                        .HasForeignKey("GuldtandMVC_Identity.IngredientList", "RecipeId")
                        .HasConstraintName("FK__ingredien__recip__57D2EA43")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuldtandMVC_Identity.OpenHours", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.RetailChain", "RetailChain")
                        .WithMany("OpenHours")
                        .HasForeignKey("RetailChainId")
                        .HasConstraintName("FK__open_hour__retai__41E3A924")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GuldtandMVC_Identity.Product", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.RetailChain", "RetailChain")
                        .WithMany("Product")
                        .HasForeignKey("RetailChainId")
                        .HasConstraintName("FK__product__retail___46A85E41");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.ProductCategory", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.Category", "CategoryNameNavigation")
                        .WithMany("ProductCategory")
                        .HasForeignKey("CategoryName")
                        .HasConstraintName("FK__product_c__categ__5031C87B");

                    b.HasOne("GuldtandMVC_Identity.Product", "Product")
                        .WithMany("ProductCategory")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__product_c__produ__4F3DA442");
                });

            modelBuilder.Entity("GuldtandMVC_Identity.RecipeCategory", b =>
                {
                    b.HasOne("GuldtandMVC_Identity.Category", "CategoryNameNavigation")
                        .WithMany("RecipeCategory")
                        .HasForeignKey("CategoryName")
                        .HasConstraintName("FK__recipe_ca__categ__5402595F");

                    b.HasOne("GuldtandMVC_Identity.Recipe", "Recipe")
                        .WithMany("RecipeCategory")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__recipe_ca__recip__530E3526");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
