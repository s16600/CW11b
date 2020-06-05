using Microsoft.EntityFrameworkCore.Migrations;

namespace CW11.Migrations
{
    public partial class ChangeIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Doctor");

            migrationBuilder.AddColumn<int>(
                name: "IdDoctor",
                table: "Doctor",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "IdDoctor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "IdDoctor",
                table: "Doctor");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "Id");
        }
    }
}
