using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Companyname", "Land", "Organisationno" },
                values: new object[,]
                {
                    { 101, "MittFöretag_S", "Sverige", "123456-7890" },
                    { 102, "MittFöretag_D", "Danmark", "567890-2345" }
                });

            migrationBuilder.InsertData(
                table: "Rolls",
                columns: new[] { "Id", "Rollname" },
                values: new object[,]
                {
                    { 1, "Utvecklare" },
                    { 2, "Databasadministratör" },
                    { 3, "Lönespecialist" },
                    { 4, "VD" },
                    { 5, "Teamchef" },
                    { 6, "Redovisningsekonom" },
                    { 7, "Administratör" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "Departmentname" },
                values: new object[,]
                {
                    { 1001, 101, "IT_S" },
                    { 1002, 101, "Ekonomi_S" },
                    { 1003, 101, "Administration_S" },
                    { 1004, 101, "Styrelse_S" },
                    { 1005, 102, "IT_D" },
                    { 1006, 102, "Ekonomi_D" },
                    { 1007, 102, "Styrelse_D" }
                });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "DepartmentId", "Firstname", "Lastname", "Sallary", "UnionMember" },
                values: new object[,]
                {
                    { 11, 1001, "Kalle", "Anka", 50000, true },
                    { 12, 1002, "Bamse", "Björn", 46000, true },
                    { 13, 1003, "Pelle", "Svanslös", 34000, false },
                    { 14, 1001, "Kajsa", "Kavat", 32000, true },
                    { 15, 1004, "Nils", "Pyssling", 35000, false },
                    { 16, 1005, "Mamma", "Mu", 41000, true },
                    { 17, 1006, "Great", "Gris", 40000, false },
                    { 18, 1007, "Pippi", "Långstrump", 38000, true }
                });

            migrationBuilder.InsertData(
                table: "EmployersRolls",
                columns: new[] { "EmployerId", "RollId" },
                values: new object[,]
                {
                    { 11, 1 },
                    { 11, 5 },
                    { 12, 3 },
                    { 13, 5 },
                    { 13, 7 },
                    { 14, 2 },
                    { 15, 4 },
                    { 16, 1 },
                    { 17, 6 },
                    { 18, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "EmployersRolls",
                keyColumns: new[] { "EmployerId", "RollId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rolls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}
