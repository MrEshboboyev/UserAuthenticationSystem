using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserAuthenticationSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "ProfilePicture", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, "123 Main St, Cityville", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8337), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", "hashed_password_1", "+1234567890", "https://example.com/john_doe_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8347), "john_doe" },
                    { 2, "456 Oak St, Townsville", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8350), new DateTime(1988, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.smith@example.com", "Alice", "Smith", "hashed_password_2", "+9876543210", "https://example.com/alice_smith_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8351), "alice_smith" },
                    { 3, "789 Pine St, Villagetown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8353), new DateTime(1985, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.jones@example.com", "Bob", "Jones", "hashed_password_3", "+1122334455", "https://example.com/bob_jones_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8353), "bob_jones" },
                    { 4, "567 Elm St, Hamletsville", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8356), new DateTime(1992, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.white@example.com", "Emily", "White", "hashed_password_4", "+9988776655", "https://example.com/emily_white_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8356), "emily_white" },
                    { 5, "456 Oak St, Townsville", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8358), new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", "hashed_password_15", "+0987654321", "https://example.com/jane_smith_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8358), "jane_smith" },
                    { 16, "876 Maple St, Grovetown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8360), new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam.green@example.com", "Sam", "Green", "hashed_password_16", "+1122334455", "https://example.com/sam_green_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8361), "sam_green" },
                    { 17, "234 Birch St, Forestville", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8362), new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.brown@example.com", "Olivia", "Brown", "hashed_password_17", "+9988776655", "https://example.com/olivia_brown_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8363), "olivia_brown" },
                    { 18, "789 Cedar St, Hilltop", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8365), new DateTime(1987, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.miller@example.com", "David", "Miller", "hashed_password_18", "+1122334455", "https://example.com/david_miller_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8366), "david_miller" },
                    { 19, "345 Pine St, Valleytown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8368), new DateTime(1994, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.turner@example.com", "Grace", "Turner", "hashed_password_19", "+9988776655", "https://example.com/grace_turner_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8368), "grace_turner" },
                    { 20, "567 Oak St, Laketown", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8370), new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryan.clark@example.com", "Ryan", "Clark", "hashed_password_20", "+1122334455", "https://example.com/ryan_clark_profile.jpg", new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8370), "ryan_clark" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

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
        }
    }
}
