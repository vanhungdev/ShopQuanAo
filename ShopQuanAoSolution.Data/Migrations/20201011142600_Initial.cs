using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopQuanAoSolution.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catid = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    slug = table.Column<string>(nullable: true),
                    img = table.Column<string>(maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    sold = table.Column<int>(nullable: false, defaultValue: 0),
                    number = table.Column<int>(nullable: false, defaultValue: 30),
                    price = table.Column<double>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<int>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: true),
                    updated_by = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
