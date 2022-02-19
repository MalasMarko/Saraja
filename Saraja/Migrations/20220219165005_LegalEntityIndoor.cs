using Microsoft.EntityFrameworkCore.Migrations;

namespace Saraja.Migrations
{
    public partial class LegalEntityIndoor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Indoor1",
                table: "LegalEntity_1",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Indoor2",
                table: "LegalEntity_1",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Indoor1",
                table: "LegalEntity_1");

            migrationBuilder.DropColumn(
                name: "Indoor2",
                table: "LegalEntity_1");
        }
    }
}
