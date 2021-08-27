using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Departments_DepartmentsId",
                table: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "City",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentsId",
                table: "City",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Departments_DepartmentsId",
                table: "City",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Departments_DepartmentsId",
                table: "City");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "City",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentsId",
                table: "City",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Departments_DepartmentsId",
                table: "City",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
