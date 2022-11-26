using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boleron.Data.Migrations
{
    public partial class creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EGN",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CarPolicy",
                columns: table => new
                {
                    CarPolicyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerID = table.Column<string>(nullable: true),
                    MoneyLimitOfInsurance = table.Column<int>(nullable: false),
                    BegginingOfInsurance = table.Column<DateTime>(nullable: false),
                    MonthsOfInsurance = table.Column<int>(nullable: false),
                    CarAge = table.Column<int>(nullable: false),
                    CarBrand = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    CarColour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPolicy", x => x.CarPolicyID);
                    table.ForeignKey(
                        name: "FK_CarPolicy_AspNetUsers_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExtremePolicy",
                columns: table => new
                {
                    ExtremePolicyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerID = table.Column<string>(nullable: true),
                    MoneyLimitOfInsurance = table.Column<int>(nullable: false),
                    BegginingOfInsurance = table.Column<DateTime>(nullable: false),
                    MonthsOfInsurance = table.Column<int>(nullable: false),
                    PractisesExtremeSport = table.Column<bool>(nullable: false),
                    NumberOfTimesAYearToPractise = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtremePolicy", x => x.ExtremePolicyID);
                    table.ForeignKey(
                        name: "FK_ExtremePolicy_AspNetUsers_OwnerID",
                        column: x => x.OwnerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarPolicy_OwnerID",
                table: "CarPolicy",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtremePolicy_OwnerID",
                table: "ExtremePolicy",
                column: "OwnerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPolicy");

            migrationBuilder.DropTable(
                name: "ExtremePolicy");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
