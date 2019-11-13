using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuldtandMVC_Identity.Migrations
{
    public partial class InitialJesper : Migration
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
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Kategori",
            //    columns: table => new
            //    {
            //        kategori = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Kategori__BFBCD94401F34AC9", x => x.kategori);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "NyVare",
            //    columns: table => new
            //    {
            //        vareID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        navn = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        butik = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        pris = table.Column<double>(nullable: true),
            //        valid_fra = table.Column<DateTime>(type: "datetime", nullable: false),
            //        valid_til = table.Column<DateTime>(type: "datetime", nullable: false),
            //        volumen = table.Column<int>(nullable: false),
            //        volumenpris = table.Column<double>(nullable: true),
            //        img_src = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__NyVare__0A039BF99CA62479", x => x.vareID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Opskrift",
            //    columns: table => new
            //    {
            //        opskriftID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        navn = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
            //        beskrivelse = table.Column<string>(unicode: false, maxLength: 1000, nullable: false),
            //        pris = table.Column<double>(nullable: false),
            //        besparelse = table.Column<double>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Opskrift", x => x.opskriftID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "recipes",
            //    columns: table => new
            //    {
            //        recipe_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        name = table.Column<string>(maxLength: 255, nullable: false),
            //        category = table.Column<string>(maxLength: 255, nullable: false),
            //        directions = table.Column<string>(maxLength: 4000, nullable: false),
            //        servings = table.Column<int>(nullable: true),
            //        price = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
            //        savings_absolute = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
            //        savings_percent = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__recipes__3571ED9B43F6CF7A", x => x.recipe_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "retail_chains",
            //    columns: table => new
            //    {
            //        name = table.Column<string>(maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__retail_c__72E12F1ADAE2682D", x => x.name);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vare",
            //    columns: table => new
            //    {
            //        vareID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        navn = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
            //        pris = table.Column<double>(nullable: true),
            //        butik = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        valid_fra = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        valid_til = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        volumenpris = table.Column<double>(nullable: true),
            //        volumen = table.Column<double>(nullable: true),
            //        imgsrc = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vare", x => x.vareID);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
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
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
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
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "prefs_categories",
            //    columns: table => new
            //    {
            //        username = table.Column<string>(maxLength: 255, nullable: false),
            //        category = table.Column<string>(maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_prefs_cat", x => new { x.username, x.category });
            //        table.ForeignKey(
            //            name: "FK_pref_cat_username",
            //            column: x => x.username,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VareKategori",
            //    columns: table => new
            //    {
            //        vareID = table.Column<int>(nullable: false),
            //        kategori = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__VareKate__51F8566D62A76F18", x => new { x.vareID, x.kategori });
            //        table.ForeignKey(
            //            name: "FK__VareKateg__kateg__00FF1D08",
            //            column: x => x.kategori,
            //            principalTable: "Kategori",
            //            principalColumn: "kategori",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK__VareKateg__vareI__000AF8CF",
            //            column: x => x.vareID,
            //            principalTable: "NyVare",
            //            principalColumn: "vareID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OpskriftKategori",
            //    columns: table => new
            //    {
            //        opskriftID = table.Column<int>(nullable: false),
            //        kategori = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Opskrift__869396F91D4CBD8D", x => new { x.opskriftID, x.kategori });
            //        table.ForeignKey(
            //            name: "FK__OpskriftK__kateg__06B7F65E",
            //            column: x => x.kategori,
            //            principalTable: "Kategori",
            //            principalColumn: "kategori",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK__OpskriftK__opskr__05C3D225",
            //            column: x => x.opskriftID,
            //            principalTable: "Opskrift",
            //            principalColumn: "opskriftID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "subscriptions",
            //    columns: table => new
            //    {
            //        username = table.Column<string>(maxLength: 255, nullable: false),
            //        recipe = table.Column<int>(nullable: false),
            //        max_price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_subscriptions", x => new { x.username, x.recipe });
            //        table.ForeignKey(
            //            name: "FK_sub_recipe",
            //            column: x => x.recipe,
            //            principalTable: "recipes",
            //            principalColumn: "recipe_id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_sub_username",
            //            column: x => x.username,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "prefs_chains",
            //    columns: table => new
            //    {
            //        username = table.Column<string>(maxLength: 255, nullable: false),
            //        retail_chain = table.Column<string>(maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_prefs_chains", x => new { x.username, x.retail_chain });
            //        table.ForeignKey(
            //            name: "FK_prefs_chains_chains",
            //            column: x => x.retail_chain,
            //            principalTable: "retail_chains",
            //            principalColumn: "name",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_prefs_chains_username",
            //            column: x => x.username,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "products",
            //    columns: table => new
            //    {
            //        product_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
            //        name = table.Column<string>(maxLength: 255, nullable: false),
            //        category = table.Column<string>(maxLength: 255, nullable: false),
            //        retail_chain = table.Column<string>(maxLength: 255, nullable: false),
            //        price_regular = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
            //        price_sale = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
            //        amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
            //        amount_unit = table.Column<string>(maxLength: 255, nullable: false),
            //        price_pr_amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
            //        savings_absolute = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
            //        savings_percent = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__products__47027DF5D8A01FFD", x => x.product_id);
            //        table.ForeignKey(
            //            name: "FK_product_chain",
            //            column: x => x.retail_chain,
            //            principalTable: "retail_chains",
            //            principalColumn: "name",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "stores",
            //    columns: table => new
            //    {
            //        store_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        retail_chain = table.Column<string>(maxLength: 255, nullable: false),
            //        name = table.Column<string>(maxLength: 255, nullable: true),
            //        address = table.Column<string>(maxLength: 255, nullable: false),
            //        hours = table.Column<string>(maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__stores__A2F2A30C987F6792", x => x.store_id);
            //        table.ForeignKey(
            //            name: "FK_stores_chains",
            //            column: x => x.retail_chain,
            //            principalTable: "retail_chains",
            //            principalColumn: "name",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Butik",
            //    columns: table => new
            //    {
            //        butikID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        vareID = table.Column<int>(nullable: false),
            //        butiknavn = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
            //        addresse = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Butik", x => x.butikID);
            //        table.ForeignKey(
            //            name: "FK__Butik__vareID__09946309",
            //            column: x => x.vareID,
            //            principalTable: "Vare",
            //            principalColumn: "vareID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ingredient_list",
            //    columns: table => new
            //    {
            //        ingredient_id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        recipe = table.Column<int>(nullable: true),
            //        ingredient_name = table.Column<string>(maxLength: 255, nullable: false),
            //        amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
            //        amount_unit = table.Column<string>(maxLength: 255, nullable: true),
            //        product_ref = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__ingredie__B0E453CF81168D6F", x => x.ingredient_id);
            //        table.ForeignKey(
            //            name: "FK_ingredients_products",
            //            column: x => x.product_ref,
            //            principalTable: "products",
            //            principalColumn: "product_id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ingredients_recipe",
            //            column: x => x.recipe,
            //            principalTable: "recipes",
            //            principalColumn: "recipe_id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Abningstid",
            //    columns: table => new
            //    {
            //        ugedag = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
            //        aben_fra = table.Column<TimeSpan>(nullable: true),
            //        aben_til = table.Column<TimeSpan>(nullable: true),
            //        butik_id = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Abningst__363950E8F57F7389", x => x.ugedag);
            //        table.ForeignKey(
            //            name: "FK__Abningsti__butik__0C70CFB4",
            //            column: x => x.butik_id,

            //            principalTable: "Butik",
            //            principalColumn: "butikID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Abningstid_butik_id",
                table: "Abningstid",
                column: "butik_id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Butik_vareID",
                table: "Butik",
                column: "vareID");

            migrationBuilder.CreateIndex(
                name: "IX_ingredient_list_product_ref",
                table: "ingredient_list",
                column: "product_ref");

            migrationBuilder.CreateIndex(
                name: "IX_ingredient_list_recipe",
                table: "ingredient_list",
                column: "recipe");

            migrationBuilder.CreateIndex(
                name: "IX_OpskriftKategori_kategori",
                table: "OpskriftKategori",
                column: "kategori");

            migrationBuilder.CreateIndex(
                name: "IX_prefs_chains_retail_chain",
                table: "prefs_chains",
                column: "retail_chain");

            migrationBuilder.CreateIndex(
                name: "IX_products_retail_chain",
                table: "products",
                column: "retail_chain");

            migrationBuilder.CreateIndex(
                name: "IX_stores_retail_chain",
                table: "stores",
                column: "retail_chain");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_recipe",
                table: "subscriptions",
                column: "recipe");

            migrationBuilder.CreateIndex(
                name: "IX_VareKategori_kategori",
                table: "VareKategori",
                column: "kategori");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abningstid");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ingredient_list");

            migrationBuilder.DropTable(
                name: "OpskriftKategori");

            migrationBuilder.DropTable(
                name: "prefs_categories");

            migrationBuilder.DropTable(
                name: "prefs_chains");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "subscriptions");

            migrationBuilder.DropTable(
                name: "VareKategori");

            migrationBuilder.DropTable(
                name: "Butik");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "Opskrift");

            migrationBuilder.DropTable(
                name: "recipes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "NyVare");

            migrationBuilder.DropTable(
                name: "Vare");

            migrationBuilder.DropTable(
                name: "retail_chains");
        }
    }
}
