using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarTax.Taxfreecar.Infrastruchar.Migrations
{
    /// <inheritdoc />
    public partial class chack0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxfreecar",
                columns: table => new
                {
                    TaxfreecarId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    TypeCarId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TaxfreecarId", x => x.TaxfreecarId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Taxfreecar");
        }
    }
}
