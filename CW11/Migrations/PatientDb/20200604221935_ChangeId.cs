using Microsoft.EntityFrameworkCore.Migrations;

namespace CW11.Migrations.PatientDb
{
    public partial class ChangeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Patient");

            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                table: "Patient",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "IdPatient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "IdPatient",
                table: "Patient");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");
        }
    }
}
