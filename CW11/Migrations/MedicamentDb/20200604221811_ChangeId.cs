using Microsoft.EntityFrameworkCore.Migrations;

namespace CW11.Migrations.MedicamentDb
{
    public partial class ChangeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Medicament");

            migrationBuilder.AddColumn<int>(
                name: "IdMedicament",
                table: "Medicament",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament",
                column: "IdMedicament");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "IdMedicament",
                table: "Medicament");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Medicament",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament",
                column: "Id");
        }
    }
}
