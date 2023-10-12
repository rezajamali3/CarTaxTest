using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTax.Car.Infrastruchar.Migrations
{
    /// <inheritdoc />
    public partial class addBesT12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    CarTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    NameTypeCar = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxActive = table.Column<bool>(type: "bit", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CarTypeId", x => x.CarTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CarTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CodePlack = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    NumberPlack = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CarId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "CarTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarTypes");
        }
    }
}
