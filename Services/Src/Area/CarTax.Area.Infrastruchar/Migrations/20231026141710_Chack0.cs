using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTax.Area.Infrastruchar.Migrations
{
    /// <inheritdoc />
    public partial class Chack0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AreaCode = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    Maximumdailytaxamount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    limitedMinutes = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AreaId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specifichourlytax",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartTimeSpan = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTimeSpan = table.Column<TimeSpan>(type: "time", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SpecifichourlytaxId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specifichourlytax_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Taxfreecar",
                columns: table => new
                {
                    TaxfreecarId = table.Column<int>(type: "int", nullable: false),
                    TypeCarId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TaxfreecarId", x => x.TaxfreecarId);
                    table.ForeignKey(
                        name: "FK_Taxfreecar_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specifichourlytax_AreaId",
                table: "Specifichourlytax",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxfreecar_AreaId",
                table: "Taxfreecar",
                column: "AreaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specifichourlytax");

            migrationBuilder.DropTable(
                name: "Taxfreecar");

            migrationBuilder.DropTable(
                name: "Area");
        }
    }
}
