using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tournois_Gamer_BlazorServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashPrizeDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinnersPrice = table.Column<int>(type: "int", nullable: false),
                    FinalistPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashPrizeDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventDtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatesString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedules = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentNameDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentNameDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentNameDto_EventDtos_EventId",
                        column: x => x.EventId,
                        principalTable: "EventDtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentNameId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    TeamNbr = table.Column<int>(type: "int", nullable: false),
                    PlayerNbrPerTeam = table.Column<int>(type: "int", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostEntry = table.Column<int>(type: "int", nullable: false),
                    CashPrizeId = table.Column<int>(type: "int", nullable: false),
                    IsTeam = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentDto_CashPrizeDto_CashPrizeId",
                        column: x => x.CashPrizeId,
                        principalTable: "CashPrizeDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentDto_EventDtos_EventId",
                        column: x => x.EventId,
                        principalTable: "EventDtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentDto_TournamentNameDto_TournamentNameId",
                        column: x => x.TournamentNameId,
                        principalTable: "TournamentNameDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TournamentDto_CashPrizeId",
                table: "TournamentDto",
                column: "CashPrizeId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentDto_EventId",
                table: "TournamentDto",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentDto_TournamentNameId",
                table: "TournamentDto",
                column: "TournamentNameId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentNameDto_EventId",
                table: "TournamentNameDto",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TournamentDto");

            migrationBuilder.DropTable(
                name: "CashPrizeDto");

            migrationBuilder.DropTable(
                name: "TournamentNameDto");

            migrationBuilder.DropTable(
                name: "EventDtos");
        }
    }
}
