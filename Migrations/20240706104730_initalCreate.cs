using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetAPIDocker.Migrations
{
    /// <inheritdoc />
    public partial class initalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "public");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "public",
                newName: "Employees");
        }
    }
}
