using Microsoft.EntityFrameworkCore.Migrations;

namespace SP.Repo.Migrations
{
    public partial class secondSDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PartManufacturer",
                table: "PartManufacturer");

            migrationBuilder.RenameTable(
                name: "PartManufacturer",
                newName: "PartManufacturers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartManufacturers",
                table: "PartManufacturers",
                column: "ManufacId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartManufacturers",
                table: "PartManufacturers");

            migrationBuilder.RenameTable(
                name: "PartManufacturers",
                newName: "PartManufacturer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartManufacturer",
                table: "PartManufacturer",
                column: "ManufacId");

        }
    }
}
