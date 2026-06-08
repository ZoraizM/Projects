using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimePlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "LeaveRequests",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "LeaveRequests",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "EmployeeTimeLogs",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeeTimeLogs",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Employees",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Employees",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Departments",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Departments",
                newName: "CreatedOn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "LeaveRequests",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "LeaveRequests",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "EmployeeTimeLogs",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "EmployeeTimeLogs",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Employees",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Employees",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Departments",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Departments",
                newName: "CreatedAt");
        }
    }
}
