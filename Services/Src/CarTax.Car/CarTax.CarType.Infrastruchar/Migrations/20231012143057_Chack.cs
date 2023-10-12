using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTax.CarType.Infrastruchar.Migrations
{
    /// <inheritdoc />
    public partial class Chack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    CarTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    TypeCarName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxActive = table.Column<bool>(type: "bit", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CarTypeId", x => x.CarTypeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarTypes");
        }
    }
}
