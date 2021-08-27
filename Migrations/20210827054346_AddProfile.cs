using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkEntity.Migrations
{
    public partial class AddProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Companys",
                table: "Companys");

            migrationBuilder.RenameTable(
                name: "Companys",
                newName: "RenamedCompany");

            migrationBuilder.RenameColumn(
                name: "Build",
                table: "RenamedCompany",
                newName: "BuildingBuild");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Architects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArchitectRecordId",
                table: "ArchitectProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RenamedCompany",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BuildingBuild",
                table: "RenamedCompany",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RenamedCompany",
                table: "RenamedCompany",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EngineersArchitects",
                columns: table => new
                {
                    ArchitectsId = table.Column<int>(type: "int", nullable: false),
                    EngineersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineersArchitects", x => new { x.ArchitectsId, x.EngineersId });
                    table.ForeignKey(
                        name: "FK_EngineersArchitects_Architects_ArchitectsId",
                        column: x => x.ArchitectsId,
                        principalTable: "Architects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EngineersArchitects_Engineers_EngineersId",
                        column: x => x.EngineersId,
                        principalTable: "Engineers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Architects_CompanyId",
                table: "Architects",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ArchitectProfiles_ArchitectRecordId",
                table: "ArchitectProfiles",
                column: "ArchitectRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EngineersArchitects_EngineersId",
                table: "EngineersArchitects",
                column: "EngineersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArchitectProfiles_Architects_ArchitectRecordId",
                table: "ArchitectProfiles",
                column: "ArchitectRecordId",
                principalTable: "Architects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Architects_RenamedCompany_CompanyId",
                table: "Architects",
                column: "CompanyId",
                principalTable: "RenamedCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArchitectProfiles_Architects_ArchitectRecordId",
                table: "ArchitectProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Architects_RenamedCompany_CompanyId",
                table: "Architects");

            migrationBuilder.DropTable(
                name: "EngineersArchitects");

            migrationBuilder.DropIndex(
                name: "IX_Architects_CompanyId",
                table: "Architects");

            migrationBuilder.DropIndex(
                name: "IX_ArchitectProfiles_ArchitectRecordId",
                table: "ArchitectProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RenamedCompany",
                table: "RenamedCompany");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Architects");

            migrationBuilder.DropColumn(
                name: "ArchitectRecordId",
                table: "ArchitectProfiles");

            migrationBuilder.RenameTable(
                name: "RenamedCompany",
                newName: "Companys");

            migrationBuilder.RenameColumn(
                name: "BuildingBuild",
                table: "Companys",
                newName: "Build");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Build",
                table: "Companys",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companys",
                table: "Companys",
                column: "Id");
        }
    }
}
