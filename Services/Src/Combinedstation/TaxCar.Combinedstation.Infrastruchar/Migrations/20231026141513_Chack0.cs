using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxCar.Combinedstation.Infrastruchar.Migrations
{
    /// <inheritdoc />
    public partial class Chack0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CombinedStations",
                columns: table => new
                {
                    CombinedStationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    StationCode = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CombinedStationsId", x => x.CombinedStationsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CombinedStations");
        }
    }
}
