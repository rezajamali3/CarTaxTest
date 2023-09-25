using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartax.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class VBN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CarTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_CarType_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxLimitDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLimitDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxLimitDay_City_Id",
                        column: x => x.Id,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxLimitMoneyDay",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLimitMoneyDay", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_TaxLimitMoneyDay_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxLimitTime",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLimitTime", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_TaxLimitTime_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxPublicholiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<DateTime>(type: "Date", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPublicholiday", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxPublicholiday_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxTaxLongTerm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DayStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTaxLongTerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxTaxLongTerm_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxWeekDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DatyTyps = table.Column<int>(type: "int", nullable: false),
                    TaxDays = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxWeekDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxWeekDay_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Idcar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxCar_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxCar_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndDate = table.Column<TimeSpan>(type: "time", nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxTime_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarType",
                columns: new[] { "Id", "CarName", "IsActive", "IsTaxActive" },
                values: new object[,]
                {
                    { 1, "Normal", true, true },
                    { 2, "Busses", true, false },
                    { 3, "...", true, false },
                    { 4, "Diplomat", true, false },
                    { 5, "Motorcycles", true, false },
                    { 6, "Military", true, false },
                    { 7, "Foreign", true, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_CityId",
                table: "Area",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarTypeId",
                table: "Car",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxCar_AreaId",
                table: "TaxCar",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxCar_CarId",
                table: "TaxCar",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPublicholiday_CityId",
                table: "TaxPublicholiday",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxTaxLongTerm_CityId",
                table: "TaxTaxLongTerm",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxTime_AreaId",
                table: "TaxTime",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxWeekDay_CityId",
                table: "TaxWeekDay",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxCar");

            migrationBuilder.DropTable(
                name: "TaxLimitDay");

            migrationBuilder.DropTable(
                name: "TaxLimitMoneyDay");

            migrationBuilder.DropTable(
                name: "TaxLimitTime");

            migrationBuilder.DropTable(
                name: "TaxPublicholiday");

            migrationBuilder.DropTable(
                name: "TaxTaxLongTerm");

            migrationBuilder.DropTable(
                name: "TaxTime");

            migrationBuilder.DropTable(
                name: "TaxWeekDay");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "CarType");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
