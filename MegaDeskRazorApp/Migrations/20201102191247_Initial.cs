using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskRazorApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(nullable: true),
                    quoteDate = table.Column<DateTime>(nullable: false),
                    rushDays = table.Column<int>(nullable: false),
                    deskWidth = table.Column<int>(nullable: false),
                    deskDepth = table.Column<int>(nullable: false),
                    deskDrawer = table.Column<int>(nullable: false),
                    desktopMaterial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
