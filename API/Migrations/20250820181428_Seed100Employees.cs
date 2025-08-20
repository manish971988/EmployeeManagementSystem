using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Seed100Employees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "IT", "Developer", "employee1@example.com", new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 1", 40500m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Marketing", "Designer", "employee2@example.com", new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 2", 41000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Customer Service", "Support", "employee3@example.com", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 3", 41500m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Human Resources", "HR", "employee4@example.com", new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 4", 42000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Finance", "Accountant", "employee5@example.com", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 5", 42500m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Business", "Analyst", "employee6@example.com", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 6", 43000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Consulting", "Consultant", "employee7@example.com", new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 7", 43500m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Operations", "Intern", "employee8@example.com", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 8", 44000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Sales", "Lead", "employee9@example.com", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 9", 44500m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "IT", "Manager", "employee10@example.com", new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 10", 45000m });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 11, "Marketing", "Developer", "employee11@example.com", new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 11", 45500m },
                    { 12, "Customer Service", "Designer", "employee12@example.com", new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 12", 46000m },
                    { 13, "Human Resources", "Support", "employee13@example.com", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 13", 46500m },
                    { 14, "Finance", "HR", "employee14@example.com", new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 14", 47000m },
                    { 15, "Business", "Accountant", "employee15@example.com", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 15", 47500m },
                    { 16, "Consulting", "Analyst", "employee16@example.com", new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 16", 48000m },
                    { 17, "Operations", "Consultant", "employee17@example.com", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 17", 48500m },
                    { 18, "Sales", "Intern", "employee18@example.com", new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 18", 49000m },
                    { 19, "IT", "Lead", "employee19@example.com", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 19", 49500m },
                    { 20, "Marketing", "Manager", "employee20@example.com", new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 20", 50000m },
                    { 21, "Customer Service", "Developer", "employee21@example.com", new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 21", 50500m },
                    { 22, "Human Resources", "Designer", "employee22@example.com", new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 22", 51000m },
                    { 23, "Finance", "Support", "employee23@example.com", new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 23", 51500m },
                    { 24, "Business", "HR", "employee24@example.com", new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 24", 52000m },
                    { 25, "Consulting", "Accountant", "employee25@example.com", new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 25", 52500m },
                    { 26, "Operations", "Analyst", "employee26@example.com", new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 26", 53000m },
                    { 27, "Sales", "Consultant", "employee27@example.com", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 27", 53500m },
                    { 28, "IT", "Intern", "employee28@example.com", new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 28", 54000m },
                    { 29, "Marketing", "Lead", "employee29@example.com", new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 29", 54500m },
                    { 30, "Customer Service", "Manager", "employee30@example.com", new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 30", 55000m },
                    { 31, "Human Resources", "Developer", "employee31@example.com", new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 31", 55500m },
                    { 32, "Finance", "Designer", "employee32@example.com", new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 32", 56000m },
                    { 33, "Business", "Support", "employee33@example.com", new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 33", 56500m },
                    { 34, "Consulting", "HR", "employee34@example.com", new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 34", 57000m },
                    { 35, "Operations", "Accountant", "employee35@example.com", new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 35", 57500m },
                    { 36, "Sales", "Analyst", "employee36@example.com", new DateTime(2020, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 36", 58000m },
                    { 37, "IT", "Consultant", "employee37@example.com", new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 37", 58500m },
                    { 38, "Marketing", "Intern", "employee38@example.com", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 38", 59000m },
                    { 39, "Customer Service", "Lead", "employee39@example.com", new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 39", 59500m },
                    { 40, "Human Resources", "Manager", "employee40@example.com", new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 40", 60000m },
                    { 41, "Finance", "Developer", "employee41@example.com", new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 41", 60500m },
                    { 42, "Business", "Designer", "employee42@example.com", new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 42", 61000m },
                    { 43, "Consulting", "Support", "employee43@example.com", new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 43", 61500m },
                    { 44, "Operations", "HR", "employee44@example.com", new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 44", 62000m },
                    { 45, "Sales", "Accountant", "employee45@example.com", new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 45", 62500m },
                    { 46, "IT", "Analyst", "employee46@example.com", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 46", 63000m },
                    { 47, "Marketing", "Consultant", "employee47@example.com", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 47", 63500m },
                    { 48, "Customer Service", "Intern", "employee48@example.com", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 48", 64000m },
                    { 49, "Human Resources", "Lead", "employee49@example.com", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 49", 64500m },
                    { 50, "Finance", "Manager", "employee50@example.com", new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 50", 65000m },
                    { 51, "Business", "Developer", "employee51@example.com", new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 51", 65500m },
                    { 52, "Consulting", "Designer", "employee52@example.com", new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 52", 66000m },
                    { 53, "Operations", "Support", "employee53@example.com", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 53", 66500m },
                    { 54, "Sales", "HR", "employee54@example.com", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 54", 67000m },
                    { 55, "IT", "Accountant", "employee55@example.com", new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 55", 67500m },
                    { 56, "Marketing", "Analyst", "employee56@example.com", new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 56", 68000m },
                    { 57, "Customer Service", "Consultant", "employee57@example.com", new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 57", 68500m },
                    { 58, "Human Resources", "Intern", "employee58@example.com", new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 58", 69000m },
                    { 59, "Finance", "Lead", "employee59@example.com", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 59", 69500m },
                    { 60, "Business", "Manager", "employee60@example.com", new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 60", 70000m },
                    { 61, "Consulting", "Developer", "employee61@example.com", new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 61", 70500m },
                    { 62, "Operations", "Designer", "employee62@example.com", new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 62", 71000m },
                    { 63, "Sales", "Support", "employee63@example.com", new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 63", 71500m },
                    { 64, "IT", "HR", "employee64@example.com", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 64", 72000m },
                    { 65, "Marketing", "Accountant", "employee65@example.com", new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 65", 72500m },
                    { 66, "Customer Service", "Analyst", "employee66@example.com", new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 66", 73000m },
                    { 67, "Human Resources", "Consultant", "employee67@example.com", new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 67", 73500m },
                    { 68, "Finance", "Intern", "employee68@example.com", new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 68", 74000m },
                    { 69, "Business", "Lead", "employee69@example.com", new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 69", 74500m },
                    { 70, "Consulting", "Manager", "employee70@example.com", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 70", 75000m },
                    { 71, "Operations", "Developer", "employee71@example.com", new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 71", 75500m },
                    { 72, "Sales", "Designer", "employee72@example.com", new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 72", 76000m },
                    { 73, "IT", "Support", "employee73@example.com", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 73", 76500m },
                    { 74, "Marketing", "HR", "employee74@example.com", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 74", 77000m },
                    { 75, "Customer Service", "Accountant", "employee75@example.com", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 75", 77500m },
                    { 76, "Human Resources", "Analyst", "employee76@example.com", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 76", 78000m },
                    { 77, "Finance", "Consultant", "employee77@example.com", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 77", 78500m },
                    { 78, "Business", "Intern", "employee78@example.com", new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 78", 79000m },
                    { 79, "Consulting", "Lead", "employee79@example.com", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 79", 79500m },
                    { 80, "Operations", "Manager", "employee80@example.com", new DateTime(2022, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 80", 80000m },
                    { 81, "Sales", "Developer", "employee81@example.com", new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 81", 80500m },
                    { 82, "IT", "Designer", "employee82@example.com", new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 82", 81000m },
                    { 83, "Marketing", "Support", "employee83@example.com", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 83", 81500m },
                    { 84, "Customer Service", "HR", "employee84@example.com", new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 84", 82000m },
                    { 85, "Human Resources", "Accountant", "employee85@example.com", new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 85", 82500m },
                    { 86, "Finance", "Analyst", "employee86@example.com", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 86", 83000m },
                    { 87, "Business", "Consultant", "employee87@example.com", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 87", 83500m },
                    { 88, "Consulting", "Intern", "employee88@example.com", new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 88", 84000m },
                    { 89, "Operations", "Lead", "employee89@example.com", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 89", 84500m },
                    { 90, "Sales", "Manager", "employee90@example.com", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 90", 85000m },
                    { 91, "IT", "Developer", "employee91@example.com", new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 91", 85500m },
                    { 92, "Marketing", "Designer", "employee92@example.com", new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 92", 86000m },
                    { 93, "Customer Service", "Support", "employee93@example.com", new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 93", 86500m },
                    { 94, "Human Resources", "HR", "employee94@example.com", new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 94", 87000m },
                    { 95, "Finance", "Accountant", "employee95@example.com", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 95", 87500m },
                    { 96, "Business", "Analyst", "employee96@example.com", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 96", 88000m },
                    { 97, "Consulting", "Consultant", "employee97@example.com", new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 97", 88500m },
                    { 98, "Operations", "Intern", "employee98@example.com", new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 98", 89000m },
                    { 99, "Sales", "Lead", "employee99@example.com", new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 99", 89500m },
                    { 100, "IT", "Manager", "employee100@example.com", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Employee 100", 90000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Sales", "Manager", "john@example.com", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 75000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "IT", "Developer", "jane@example.com", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 65000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Marketing", "Designer", "alice@example.com", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Johnson", 60000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Customer Service", "Support", "bob@example.com", new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob Brown", 50000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Human Resources", "HR", "charlie@example.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie Lee", 70000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Finance", "Accountant", "eva@example.com", new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eva Green", 68000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Business", "Analyst", "frank@example.com", new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank White", 72000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Consulting", "Consultant", "grace@example.com", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace Black", 80000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "IT", "Intern", "henry@example.com", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry King", 35000m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Department", "Designation", "Email", "JoiningDate", "Name", "Salary" },
                values: new object[] { "Operations", "Lead", "ivy@example.com", new DateTime(2018, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivy Queen", 90000m });
        }
    }
}
