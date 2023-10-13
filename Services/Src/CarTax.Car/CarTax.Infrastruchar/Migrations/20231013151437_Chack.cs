using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTax.Car.Infrastruchar.Migrations
{
    /// <inheritdoc />
    public partial class Chack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CarTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CodePlack = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    NumberPlack = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CarId", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
