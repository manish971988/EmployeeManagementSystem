using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Sales", "Manager", "john@example.com", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 75000m },
                    { 2, "IT", "Developer", "jane@example.com", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 65000m },
                    { 3, "Marketing", "Designer", "alice@example.com", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson", 60000m },
                    { 4, "Customer Service", "Support", "bob@example.com", new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown", 50000m },
                    { 5, "Human Resources", "HR", "charlie@example.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie Lee", 70000m },
                    { 6, "Finance", "Accountant", "eva@example.com", new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eva Green", 68000m },
                    { 7, "Business", "Analyst", "frank@example.com", new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank White", 72000m },
                    { 8, "Consulting", "Consultant", "grace@example.com", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace Black", 80000m },
                    { 9, "IT", "Intern", "henry@example.com", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry King", 35000m },
                    { 10, "Operations", "Lead", "ivy@example.com", new DateTime(2018, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivy Queen", 90000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
