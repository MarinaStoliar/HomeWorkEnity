using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkEntity.Migrations
{
    public partial class addBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Build",
                table: "Companys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Build",
                table: "Companys");
        }
    }
}
