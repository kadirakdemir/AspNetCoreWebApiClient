using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreWebApi.Api.Infrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1, "Çorbalar", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 2, "Kebaplar", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 3, "Salatalar", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 4, "İçecekler", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 5, "Balıklar", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 6, "Sulu Yemekler", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 7, "Meyveler", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 8, "Tatlılar", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true },
                    { 9, "Kuru Yemiş", "Anadolunun mutfağından tap taze organik ürünlerden elde ettiğimiz kendi mahsüllerimiz ile usta aşçılarımızların ellerinden çıkma yemekler. ", true }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, null, true, "Mercimek", 5.0, 100 },
                    { 16, 8, null, true, "Sütlaç", 8.0, 100 },
                    { 15, 8, null, true, "Baklava", 10.0, 100 },
                    { 14, 7, null, true, "Elma", 1.0, 275 },
                    { 13, 7, null, true, "Portakal", 1.0, 300 },
                    { 12, 6, null, true, "Hamsi Tava", 25.0, 40 },
                    { 11, 6, null, true, "Uskumru", 25.0, 25 },
                    { 10, 5, null, true, "Bezelye", 10.0, 70 },
                    { 9, 5, null, true, "Kuru Fasülye", 12.0, 90 },
                    { 8, 4, null, true, "Ayran", 3.0, 200 },
                    { 7, 4, null, true, "Kola", 4.0, 150 },
                    { 6, 3, null, true, "Havuç", 6.0, 40 },
                    { 5, 3, null, true, "Mevsim", 8.0, 100 },
                    { 4, 2, null, true, "Adana", 25.0, 80 },
                    { 3, 2, null, true, "İskender", 25.0, 70 },
                    { 2, 1, null, true, "Ezogelin", 5.0, 95 },
                    { 17, 9, null, true, "Fındık", 5.0, 1000 },
                    { 18, 9, null, true, "Fıstık", 5.0, 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
