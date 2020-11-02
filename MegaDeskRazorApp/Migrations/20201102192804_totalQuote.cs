using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskRazorApp.Migrations
{
    public partial class totalQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "totalQuote",
                table: "Quote",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalQuote",
                table: "Quote");
        }
    }
}
