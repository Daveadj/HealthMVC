using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Persons",
                newName: "YearOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearOfBirth",
                table: "Persons",
                newName: "Age");
        }
    }
}
