using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentProgram",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    ConductingLeader = table.Column<string>(nullable: true),
                    OpeningSong = table.Column<string>(nullable: true),
                    SacramentHymn = table.Column<string>(nullable: true),
                    ClosingSong = table.Column<string>(nullable: true),
                    OptionalSong = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true),
                    Speakers = table.Column<string>(nullable: true),
                    SpeakerSubjects = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentProgram", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentProgram");
        }
    }
}
