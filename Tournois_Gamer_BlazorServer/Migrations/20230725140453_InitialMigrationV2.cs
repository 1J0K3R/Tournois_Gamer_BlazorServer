using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tournois_Gamer_BlazorServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InscriptionIndividualDto",
                columns: table => new
                {
                    InscriptionIndividualDtoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscriptionIndividualDto", x => x.InscriptionIndividualDtoId);
                    table.ForeignKey(
                        name: "FK_InscriptionIndividualDto_TournamentDto_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "TournamentDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InscriptionTeamDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    PlayersIdCaptainId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscriptionTeamDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InscriptionTeamDto_TournamentDto_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "TournamentDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateBorn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pseudo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InscriptionTeamDtoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerDto_InscriptionTeamDto_InscriptionTeamDtoId",
                        column: x => x.InscriptionTeamDtoId,
                        principalTable: "InscriptionTeamDto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InscriptionIndividualDto_PlayerId",
                table: "InscriptionIndividualDto",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_InscriptionIndividualDto_TournamentId",
                table: "InscriptionIndividualDto",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_InscriptionTeamDto_PlayersIdCaptainId",
                table: "InscriptionTeamDto",
                column: "PlayersIdCaptainId");

            migrationBuilder.CreateIndex(
                name: "IX_InscriptionTeamDto_TournamentId",
                table: "InscriptionTeamDto",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerDto_InscriptionTeamDtoId",
                table: "PlayerDto",
                column: "InscriptionTeamDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_InscriptionIndividualDto_PlayerDto_PlayerId",
                table: "InscriptionIndividualDto",
                column: "PlayerId",
                principalTable: "PlayerDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InscriptionTeamDto_PlayerDto_PlayersIdCaptainId",
                table: "InscriptionTeamDto",
                column: "PlayersIdCaptainId",
                principalTable: "PlayerDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InscriptionTeamDto_PlayerDto_PlayersIdCaptainId",
                table: "InscriptionTeamDto");

            migrationBuilder.DropTable(
                name: "InscriptionIndividualDto");

            migrationBuilder.DropTable(
                name: "PlayerDto");

            migrationBuilder.DropTable(
                name: "InscriptionTeamDto");
        }
    }
}
