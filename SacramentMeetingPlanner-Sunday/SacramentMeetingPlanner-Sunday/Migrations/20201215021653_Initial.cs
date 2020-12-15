using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner_Sunday.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingPlanner",
                columns: table => new
                {
                    MeetingPlannerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    ConductingLeader = table.Column<string>(nullable: true),
                    OpeningHymnNumber = table.Column<int>(nullable: false),
                    OpeningHymnTitle = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    SacramentHymnNumber = table.Column<int>(nullable: false),
                    SacramentHymnTitle = table.Column<string>(nullable: true),
                    IntermediateHymnNumber = table.Column<int>(nullable: false),
                    IntermediateHymnTitle = table.Column<string>(nullable: true),
                    ClosingHymnNumber = table.Column<int>(nullable: false),
                    ClosingHymnTitle = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPlanner", x => x.MeetingPlannerID);
                });

            migrationBuilder.CreateTable(
                name: "MeetingSpeaker",
                columns: table => new
                {
                    MeetingSpeakerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingSpeakerName = table.Column<string>(maxLength: 50, nullable: false),
                    MeetingSpeakerTopic = table.Column<string>(maxLength: 80, nullable: false),
                    MeetingPlannerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingSpeaker", x => x.MeetingSpeakerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingPlanner");

            migrationBuilder.DropTable(
                name: "MeetingSpeaker");
        }
    }
}
