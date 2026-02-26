using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GateAccessManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GaragePresets",
                columns: table => new
                {
                    GaragePresetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GarageCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaragePresets", x => x.GaragePresetId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    UserPin = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VacatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsUserDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastUserEntrance = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastUserPayment = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDisabled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    GarageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GarageBuilding = table.Column<int>(type: "INTEGER", nullable: false),
                    GaragePresetId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.GarageId);
                    table.ForeignKey(
                        name: "FK_Garages_GaragePresets_GaragePresetId",
                        column: x => x.GaragePresetId,
                        principalTable: "GaragePresets",
                        principalColumn: "GaragePresetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Garages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garages_GaragePresetId",
                table: "Garages",
                column: "GaragePresetId");

            migrationBuilder.CreateIndex(
                name: "IX_Garages_UserId",
                table: "Garages",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garages");

            migrationBuilder.DropTable(
                name: "GaragePresets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
