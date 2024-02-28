using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserAuthenticationSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8132), new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8134), new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "ProfilePicture", "UpdatedAt" },
                values: new object[,]
                {
                    { 6, "876 Maple St, Grovetown", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8136), new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam.green@example.com", "Sam", "Green", "hashed_password_16", "+1122334455", "https://example.com/sam_green_profile.jpg", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8137) },
                    { 7, "234 Birch St, Forestville", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8139), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.brown@example.com", "Olivia", "Brown", "hashed_password_17", "+9988776655", "https://example.com/olivia_brown_profile.jpg", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8139) },
                    { 8, "789 Cedar St, Hilltop", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8141), new DateTime(1987, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.miller@example.com", "David", "Miller", "hashed_password_18", "+1122334455", "https://example.com/david_miller_profile.jpg", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8142) },
                    { 9, "345 Pine St, Valleytown", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8144), new DateTime(1994, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.turner@example.com", "Grace", "Turner", "hashed_password_19", "+9988776655", "https://example.com/grace_turner_profile.jpg", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8144) },
                    { 10, "567 Oak St, Laketown", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8146), new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryan.clark@example.com", "Ryan", "Clark", "hashed_password_20", "+1122334455", "https://example.com/ryan_clark_profile.jpg", new DateTime(2024, 2, 28, 20, 16, 23, 666, DateTimeKind.Local).AddTicks(8146) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt", "Username" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8347), "john_doe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "Username" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8350), new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8351), "alice_smith" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt", "Username" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8353), new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8353), "bob_jones" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "Username" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8356), "emily_white" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt", "Username" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8358), "jane_smith" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "ProfilePicture", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 16, "876 Maple St, Grovetown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8360), new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam.green@example.com", "Sam", "Green", "hashed_password_16", "+1122334455", "https://example.com/sam_green_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8361), "sam_green" },
                    { 17, "234 Birch St, Forestville", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8362), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.brown@example.com", "Olivia", "Brown", "hashed_password_17", "+9988776655", "https://example.com/olivia_brown_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8363), "olivia_brown" },
                    { 18, "789 Cedar St, Hilltop", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8365), new DateTime(1987, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.miller@example.com", "David", "Miller", "hashed_password_18", "+1122334455", "https://example.com/david_miller_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8366), "david_miller" },
                    { 19, "345 Pine St, Valleytown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8368), new DateTime(1994, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.turner@example.com", "Grace", "Turner", "hashed_password_19", "+9988776655", "https://example.com/grace_turner_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8368), "grace_turner" },
                    { 20, "567 Oak St, Laketown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8370), new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryan.clark@example.com", "Ryan", "Clark", "hashed_password_20", "+1122334455", "https://example.com/ryan_clark_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8370), "ryan_clark" }
                });
        }
    }
}
