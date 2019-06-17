using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addedseedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Games");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 1, null, null, "Massively Multiplayer Online" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 12, null, null, "Educational" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 11, null, null, "Role-Playing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 9, null, null, "First Person Shooters" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 8, null, null, "Combat" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 7, null, null, "Stealth Shooter" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 10, null, null, "Sports" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 5, null, null, "Puzzle" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 4, null, null, "Real-Time Strategy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 3, null, null, "Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 2, null, null, "Simulations" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 6, null, null, "Action" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 1, null, null, "Ubisoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 2, null, null, "Electronic Arts" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 3, null, null, "Nintendo" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 4, null, null, "Sony" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 5, null, null, "Rockstar Games" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 1, null, null, "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[] { 2, null, null, "User" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 3, 8, 1, null, "This is a description for assassins game", null, "Assassin Creed" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 4, 9, 1, null, "This is a description for Tom Clancy", null, "Tom Clancy" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 5, 7, 1, null, "This is a description for Prince of Persia", null, "Prince of Persia" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 6, 1, 1, null, "This is a description for Far Cry", null, "Far Cry" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 1, 2, 2, null, "Racing game", null, "Need for Speed" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, 10, 2, null, "This is a description for FIFA 19", null, "FIFA 19" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 8, 4, 2, null, "This is a description for The Sims 4", null, "The Sims 4" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 10, 8, 3, null, "This is a description for Mario Bros", null, "Mario Bros" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 2, 3, 4, null, "Childhood game", null, "Mario Kart" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "CompanyId", "DeletedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 9, 12, 5, null, "This is a description for Grand Theft Auto", null, "Grand Theft Auto" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeletedAt", "Email", "FirstName", "LastName", "ModifiedAt", "Password", "RoleId" },
                values: new object[] { 1, null, "examleadmin@example.com", "Admin", "Admin", null, "admin", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeletedAt", "Email", "FirstName", "LastName", "ModifiedAt", "Password", "RoleId" },
                values: new object[] { 2, null, "examleuser@example.com", "User", "User", null, "user", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }
    }
}
