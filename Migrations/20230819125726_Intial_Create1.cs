using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WepAPICore.Migrations
{
    /// <inheritdoc />
    public partial class Intial_Create1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Users",
                newName: "CaseDescription");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Users",
                newName: "CaseDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "CaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CaseDescription",
                table: "Users",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CaseDate",
                table: "Users",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CaseId",
                table: "Users",
                newName: "Id");
        }
    }
}
