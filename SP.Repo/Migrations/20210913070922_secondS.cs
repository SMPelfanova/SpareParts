using Microsoft.EntityFrameworkCore.Migrations;

namespace SP.Repo.Migrations
{
    public partial class secondS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.AddColumn<int>(
                name: "CurrentManufacturerId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartManufacturer",
                columns: table => new
                {
                    ManufacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartManufacturer", x => x.ManufacId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parts_CurrentManufacturerId",
                table: "Parts",
                column: "CurrentManufacturerId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "PartManufacturer");

            migrationBuilder.DropIndex(
                name: "IX_Parts_CurrentManufacturerId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "CurrentManufacturerId",
                table: "Parts");

        }
    }
}
