using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSaloon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saloon",
                columns: table => new
                {
                    SaloonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaloonName = table.Column<string>(nullable: true),
                    SaloonAddress = table.Column<string>(nullable: true),
                    Contact_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saloon", x => x.SaloonID);
                });

            migrationBuilder.CreateTable(
                name: "Beautician",
                columns: table => new
                {
                    BeauticianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeauticianName = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<int>(nullable: false),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    SaloonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beautician", x => x.BeauticianID);
                    table.ForeignKey(
                        name: "FK_Beautician_Saloon_SaloonID",
                        column: x => x.SaloonID,
                        principalTable: "Saloon",
                        principalColumn: "SaloonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    SaloonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Saloon_SaloonID",
                        column: x => x.SaloonID,
                        principalTable: "Saloon",
                        principalColumn: "SaloonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<int>(nullable: false),
                    Expenses = table.Column<int>(nullable: false),
                    BeauticianID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Beautician_BeauticianID",
                        column: x => x.BeauticianID,
                        principalTable: "Beautician",
                        principalColumn: "BeauticianID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beautician_SaloonID",
                table: "Beautician",
                column: "SaloonID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_BeauticianID",
                table: "Customer",
                column: "BeauticianID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SaloonID",
                table: "Product",
                column: "SaloonID");
            var sqlFile = Path.Combine(".\\DatabaseScript", @"script.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Beautician");

            migrationBuilder.DropTable(
                name: "Saloon");
        }
    }
}
