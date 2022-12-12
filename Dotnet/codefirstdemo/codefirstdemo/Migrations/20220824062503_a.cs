using Microsoft.EntityFrameworkCore.Migrations;

namespace codefirstdemo.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Age", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 1, "New York", 28, "XYZ Inc", "Developer", "John", 30000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Age", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 2, "New York", 25, "ABC Inc", "Manager", "Chris", 50000f });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "Age", "CompanyName", "Designation", "Name", "Salary" },
                values: new object[] { 3, "New Delhi", 26, "XYZ Inc", "Consultant", "Mukesh", 20000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
