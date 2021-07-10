using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStoreAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1942, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe", "Biden" },
                    { 2, new DateTime(1946, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", "Trump" },
                    { 3, new DateTime(1961, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barack", "Obama" },
                    { 4, new DateTime(1946, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Bush" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CustomerId", "TripDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ItemName", "Quantity", "TripId" },
                values: new object[,]
                {
                    { 1, "Apple", 1, 1 },
                    { 28, "Bread", 2, 9 },
                    { 27, "Grapes", 1, 8 },
                    { 26, "Break", 2, 8 },
                    { 25, "Apple Juice", 2, 8 },
                    { 24, "Water", 1, 7 },
                    { 23, "Honey Roasted Peanuts", 1, 7 },
                    { 22, "Prezels", 1, 7 },
                    { 21, "Mountain Dew", 2, 6 },
                    { 20, "Cherries", 2, 6 },
                    { 19, "Grapes", 2, 6 },
                    { 18, "Oat Milk", 1, 5 },
                    { 17, "Honey Smacks", 2, 5 },
                    { 16, "Lucky Charms", 2, 5 },
                    { 15, "Diet Pepesi", 4, 4 },
                    { 14, "Mountain Dew", 1, 4 },
                    { 13, "Cranberry Juice", 1, 4 },
                    { 12, "Cocoa Pebbles", 1, 3 },
                    { 11, "Strawberries", 1, 3 },
                    { 10, "Grapes", 1, 3 },
                    { 9, "Orange Juice", 1, 3 },
                    { 8, "Apple Juice", 1, 2 },
                    { 7, "Out Milk", 3, 2 },
                    { 6, "Bagels", 1, 2 },
                    { 5, "Bread", 1, 2 },
                    { 4, "Oatmeal", 2, 1 },
                    { 3, "Fruity Pebbles", 1, 1 },
                    { 2, "Milk", 1, 1 },
                    { 29, "Hot Dogs", 2, 9 },
                    { 30, "Ground Beef", 1, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_TripId",
                table: "Products",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_CustomerId",
                table: "Trips",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
