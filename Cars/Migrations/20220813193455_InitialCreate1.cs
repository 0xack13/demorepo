using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_CarTypes_CarId",
                table: "Parts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarTypes",
                table: "CarTypes");

            migrationBuilder.RenameTable(
                name: "CarTypes",
                newName: "Cars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Cars_CarId",
                table: "Parts",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Cars_CarId",
                table: "Parts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "CarTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarTypes",
                table: "CarTypes",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_CarTypes_CarId",
                table: "Parts",
                column: "CarId",
                principalTable: "CarTypes",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
