using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuldtandMVC_Identity.Migrations
{
    public partial class TestForIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_AspNetRoles", x => x.Id); });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_AspNetUsers", x => x.Id); });

            //migrationBuilder.CreateTable(
            //    name: "blacklist",
            //    columns: table => new
            //    {
            //        category = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__blacklis__F7F53CC351A434DF", x => x.category);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "category",
            //    columns: table => new
            //    {
            //        category_name = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__category__5189E254535378E8", x => x.category_name);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "recipe",
            //    columns: table => new
            //    {
            //        recipe_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        name = table.Column<string>(maxLength: 255, nullable: false),
            //        servings = table.Column<int>(nullable: true),
            //        price = table.Column<double>(nullable: true),
            //        savings_absolute = table.Column<double>(nullable: true),
            //        cook_time = table.Column<int>(nullable: false),
            //        img_src = table.Column<string>(maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_recipe", x => x.recipe_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "retail_chain",
            //    columns: table => new
            //    {
            //        retail_chain_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        name = table.Column<string>(maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_retail_chain", x => x.retail_chain_id);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy",
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new {x.LoginProvider, x.ProviderKey});
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new {x.UserId, x.RoleId});
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new {x.UserId, x.LoginProvider, x.Name});
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "directions",
            //    columns: table => new
            //    {
            //        directions_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        description = table.Column<string>(maxLength: 255, nullable: false),
            //        recipe_id = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_directions", x => x.directions_id);
            //        table.ForeignKey(
            //            name: "FK__direction__recip__6621099A",
            //            column: x => x.recipe_id,
            //            principalTable: "recipe",
            //            principalColumn: "recipe_id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ingredientList",
            //    columns: table => new
            //    {
            //        ingredientList_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        recipe_id = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ingredientList", x => x.ingredientList_id);
            //        table.ForeignKey(
            //            name: "FK__ingredien__recip__57D2EA43",
            //            column: x => x.recipe_id,
            //            principalTable: "recipe",
            //            principalColumn: "recipe_id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "recipe_category",
            //    columns: table => new
            //    {
            //        recipe_id = table.Column<int>(nullable: false),
            //        category_name = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__recipe_c__606973BEB82D8C04", x => new { x.recipe_id, x.category_name });
            //        table.ForeignKey(
            //            name: "FK__recipe_ca__categ__5402595F",
            //            column: x => x.category_name,
            //            principalTable: "category",
            //            principalColumn: "category_name",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__recipe_ca__recip__530E3526",
            //            column: x => x.recipe_id,
            //            principalTable: "recipe",
            //            principalColumn: "recipe_id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "open_hours",
            //    columns: table => new
            //    {
            //        day_of_week = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
            //        open_from = table.Column<TimeSpan>(nullable: true),
            //        open_to = table.Column<TimeSpan>(nullable: true),
            //        retail_chain_id = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__open_hou__869EECA867AD9B20", x => x.day_of_week);
            //        table.ForeignKey(
            //            name: "FK__open_hour__retai__41E3A924",
            //            column: x => x.retail_chain_id,
            //            principalTable: "retail_chain",
            //            principalColumn: "retail_chain_id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "product",
            //    columns: table => new
            //    {
            //        product_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        valid_from = table.Column<DateTime>(type: "datetime", nullable: false),
            //        valid_to = table.Column<DateTime>(type: "datetime", nullable: false),
            //        name = table.Column<string>(maxLength: 100, nullable: false),
            //        price = table.Column<double>(nullable: false),
            //        volume = table.Column<double>(nullable: false),
            //        volume_price = table.Column<double>(nullable: true),
            //        img_src = table.Column<string>(maxLength: 255, nullable: true),
            //        retail_chain_id = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_product", x => x.product_id);
            //        table.ForeignKey(
            //            name: "FK__product__retail___46A85E41",
            //            column: x => x.retail_chain_id,
            //            principalTable: "retail_chain",
            //            principalColumn: "retail_chain_id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ingredient",
            //    columns: table => new
            //    {
            //        ingredient_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        name = table.Column<string>(maxLength: 100, nullable: false),
            //        amount = table.Column<double>(nullable: true),
            //        amount_unit = table.Column<string>(maxLength: 15, nullable: true),
            //        product_id = table.Column<int>(nullable: true),
            //        ingredientList_id = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ingredient", x => x.ingredient_id);
            //        table.ForeignKey(
            //            name: "FK__ingredien__ingre__60683044",
            //            column: x => x.ingredientList_id,
            //            principalTable: "ingredientList",
            //            principalColumn: "ingredientList_id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK__ingredien__produ__5F740C0B",
            //            column: x => x.product_id,
            //            principalTable: "product",
            //            principalColumn: "product_id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "product_category",
            //    columns: table => new
            //    {
            //        product_id = table.Column<int>(nullable: false),
            //        category_name = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__product___121AE3D0B94E8F57", x => new { x.product_id, x.category_name });
            //        table.ForeignKey(
            //            name: "FK__product_c__categ__5031C87B",
            //            column: x => x.category_name,
            //            principalTable: "category",
            //            principalColumn: "category_name",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__product_c__produ__4F3DA442",
            //            column: x => x.product_id,
            //            principalTable: "product",
            //            principalColumn: "product_id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        //    migrationBuilder.CreateIndex(
        //        name: "IX_directions_recipe_id",
        //        table: "directions",
        //        column: "recipe_id");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ingredient_ingredientList_id",
        //        table: "ingredient",
        //        column: "ingredientList_id");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ingredient_product_id",
        //        table: "ingredient",
        //        column: "product_id");

        //    migrationBuilder.CreateIndex(
        //        name: "UQ__ingredie__3571ED9A29CD80B9",
        //        table: "ingredientList",
        //        column: "recipe_id",
        //        unique: true,
        //        filter: "[recipe_id] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_open_hours_retail_chain_id",
        //        table: "open_hours",
        //        column: "retail_chain_id");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_product_retail_chain_id",
        //        table: "product",
        //        column: "retail_chain_id");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_product_category_category_name",
        //        table: "product_category",
        //        column: "category_name");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_recipe_category_category_name",
        //        table: "recipe_category",
        //        column: "category_name");
        //}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AspNetRoleClaims");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserClaims");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserLogins");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserRoles");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "blacklist");

            //migrationBuilder.DropTable(
            //    name: "directions");

            //migrationBuilder.DropTable(
            //    name: "ingredient");

            //migrationBuilder.DropTable(
            //    name: "open_hours");

            //migrationBuilder.DropTable(
            //    name: "product_category");

            //migrationBuilder.DropTable(
            //    name: "recipe_category");

            //migrationBuilder.DropTable(
            //    name: "AspNetRoles");

            //migrationBuilder.DropTable(
            //    name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "ingredientList");

            //migrationBuilder.DropTable(
            //    name: "product");

            //migrationBuilder.DropTable(
            //    name: "category");

            //migrationBuilder.DropTable(
            //    name: "recipe");

            //migrationBuilder.DropTable(
            //    name: "retail_chain");
        }
    }
}
