using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartax.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class CarTax0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxLimitDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLimitDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxPublicholiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<DateTime>(type: "Date", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPublicholiday", x => x.Id);
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
                    Idarea = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_City_idCity",
                        column: x => x.idCity,
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idcity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarType_City_Idcity",
                        column: x => x.Idcity,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxLimitMoneyDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLimitMoneyDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxLimitMoneyDay_Area_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "TaxLimitTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxLimitTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxLimitTime_Area_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "TaxTaxLongTerm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: true),
                    DayStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTaxLongTerm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxTaxLongTerm_Area_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "TaxWeekDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArea = table.Column<int>(type: "int", nullable: true),
                    DatyTyps = table.Column<int>(type: "int", nullable: false),
                    TaxDays = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxWeekDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxWeekDay_Area_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCarType = table.Column<int>(type: "int", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_CarType_IdCarType",
                        column: x => x.IdCarType,
                        principalTable: "CarType",
                        principalColumn: "Id",
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
                    Idarea = table.Column<int>(type: "int", nullable: true),
                    Idcar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxCar_Area_Idarea",
                        column: x => x.Idarea,
                        principalTable: "Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxCar_Car_Idcar",
                        column: x => x.Idcar,
                        principalTable: "Car",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "Id", "AreaCode", "AreaName", "idCity" },
                values: new object[,]
                {
                    { 1, "1", "Gothenburِ", null },
                    { 2, "2", "GothenburgA", null },
                    { 3, "3", "GothenburgB", null },
                    { 4, "4", "GothenburgC", null }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CityCode", "CityName" },
                values: new object[,]
                {
                    { 1, "FitNet10", "Gothenburg" },
                    { 2, "FitNet45", "Eroica" },
                    { 3, "FitNet48", "Avesta" }
                });

            migrationBuilder.InsertData(
                table: "TaxLimitDay",
                columns: new[] { "Id", "IdArea", "IsActive", "Time" },
                values: new object[] { 1, 1, true, new TimeSpan(0, 0, 59, 0, 0) });

            migrationBuilder.InsertData(
                table: "TaxPublicholiday",
                columns: new[] { "Id", "Day", "IdArea", "IsActive" },
                values: new object[] { 1, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, true });

            migrationBuilder.InsertData(
                table: "TaxTime",
                columns: new[] { "Id", "EndDate", "Idarea", "StartDate", "Tax" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 6, 29, 0, 0), 1, new TimeSpan(0, 6, 0, 0, 0), 8m },
                    { 2, new TimeSpan(0, 6, 59, 0, 0), 1, new TimeSpan(0, 6, 30, 0, 0), 13m },
                    { 3, new TimeSpan(0, 7, 59, 0, 0), 1, new TimeSpan(0, 7, 0, 0, 0), 18m },
                    { 4, new TimeSpan(0, 8, 29, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 13m },
                    { 5, new TimeSpan(0, 14, 59, 0, 0), 1, new TimeSpan(0, 8, 30, 0, 0), 18m },
                    { 6, new TimeSpan(0, 15, 29, 0, 0), 1, new TimeSpan(0, 15, 0, 0, 0), 13m },
                    { 7, new TimeSpan(0, 16, 59, 0, 0), 1, new TimeSpan(0, 15, 30, 0, 0), 18m },
                    { 8, new TimeSpan(0, 17, 59, 0, 0), 1, new TimeSpan(0, 17, 0, 0, 0), 13m },
                    { 9, new TimeSpan(0, 18, 29, 0, 0), 1, new TimeSpan(0, 18, 0, 0, 0), 8m },
                    { 10, new TimeSpan(1, 0, 0, 0, 0), 1, new TimeSpan(0, 18, 30, 0, 0), 8m },
                    { 11, new TimeSpan(0, 5, 59, 0, 0), 1, new TimeSpan(0, 0, 0, 0, 0), 8m }
                });

            migrationBuilder.InsertData(
                table: "CarType",
                columns: new[] { "Id", "CarName", "Idcity", "IsActive", "IsTaxActive" },
                values: new object[,]
                {
                    { 1, "Normal", 1, true, true },
                    { 2, "Emergency", 1, true, false },
                    { 3, "Busses", 1, true, false },
                    { 4, "Diplomat", 1, true, false },
                    { 5, "Motorcycles", 1, true, false },
                    { 6, "Military", 1, true, false },
                    { 7, "Foreign", 1, true, false }
                });

            migrationBuilder.InsertData(
                table: "TaxLimitMoneyDay",
                columns: new[] { "Id", "IdArea", "Tax" },
                values: new object[] { 1, 1, 60m });

            migrationBuilder.InsertData(
                table: "TaxLimitTime",
                columns: new[] { "Id", "IdArea", "IsActive", "Time" },
                values: new object[] { 1, 1, true, new TimeSpan(0, 1, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TaxTaxLongTerm",
                columns: new[] { "Id", "DayEnd", "DayStart", "IdArea", "IsActive" },
                values: new object[] { 1, new DateTime(2013, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.InsertData(
                table: "TaxWeekDay",
                columns: new[] { "Id", "DatyTyps", "IdArea", "IsActive", "TaxDays" },
                values: new object[,]
                {
                    { 1, 6, 1, true, 10 },
                    { 2, 7, 1, true, 10 }
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "CarName", "IdCarType" },
                values: new object[,]
                {
                    { 1, "Car.A", 1 },
                    { 2, "Car.B", 2 },
                    { 3, "Car.C", 3 },
                    { 4, "Car.D", 4 },
                    { 5, "Car.F", 5 },
                    { 6, "Car.H", 6 },
                    { 7, "Car.X", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_idCity",
                table: "Area",
                column: "idCity");

            migrationBuilder.CreateIndex(
                name: "IX_Car_IdCarType",
                table: "Car",
                column: "IdCarType");

            migrationBuilder.CreateIndex(
                name: "IX_CarType_Idcity",
                table: "CarType",
                column: "Idcity");

            migrationBuilder.CreateIndex(
                name: "IX_TaxCar_Idarea",
                table: "TaxCar",
                column: "Idarea");

            migrationBuilder.CreateIndex(
                name: "IX_TaxCar_Idcar",
                table: "TaxCar",
                column: "Idcar");

            migrationBuilder.CreateIndex(
                name: "IX_TaxLimitMoneyDay_IdArea",
                table: "TaxLimitMoneyDay",
                column: "IdArea",
                unique: true,
                filter: "[IdArea] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TaxLimitTime_IdArea",
                table: "TaxLimitTime",
                column: "IdArea",
                unique: true,
                filter: "[IdArea] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TaxTaxLongTerm_IdArea",
                table: "TaxTaxLongTerm",
                column: "IdArea",
                unique: true,
                filter: "[IdArea] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TaxWeekDay_IdArea",
                table: "TaxWeekDay",
                column: "IdArea");
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
