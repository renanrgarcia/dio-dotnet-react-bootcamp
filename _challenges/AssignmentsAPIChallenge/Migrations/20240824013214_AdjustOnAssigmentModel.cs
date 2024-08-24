using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentsAPIChallenge.Migrations
{
    /// <inheritdoc />
    public partial class AdjustOnAssigmentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Assignments",
                newName: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Assignments",
                newName: "Data");
        }
    }
}
