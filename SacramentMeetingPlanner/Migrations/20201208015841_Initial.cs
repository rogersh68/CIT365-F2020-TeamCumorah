using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class Initial : Migration
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
                    ConductingLeader = table.Column<string>(nullable: false),
                    OpeningSong = table.Column<int>(nullable: false),
                    SacramentHymn = table.Column<int>(nullable: false),
                    ClosingSong = table.Column<int>(nullable: false),
                    OptionalSong = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentProgram", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerName = table.Column<string>(nullable: true),
                    SpeakerTopic = table.Column<string>(nullable: true),
                    SacramentProgramID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speaker_SacramentProgram_SacramentProgramID",
                        column: x => x.SacramentProgramID,
                        principalTable: "SacramentProgram",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_SacramentProgramID",
                table: "Speaker",
                column: "SacramentProgramID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "SacramentProgram");
        }
    }
}
