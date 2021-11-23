using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jobPortalAPI.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BusinessId",
                table: "Company",
                newName: "CompanyBusinessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyBusinessId",
                table: "Company",
                newName: "BusinessId");
        }
    }
}
