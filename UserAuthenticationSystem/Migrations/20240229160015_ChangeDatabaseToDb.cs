using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserAuthenticationSystem.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDatabaseToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    ProfilePicture = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "ProfilePicture", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Main St, Cityville", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5367), new DateTime(1990, 5, 14, 19, 0, 0, 0, DateTimeKind.Utc), "john.doe@example.com", "John", "Doe", "hashed_password_1", "+1234567890", "https://example.com/john_doe_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5368) },
                    { 2, "456 Oak St, Townsville", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5372), new DateTime(1988, 11, 7, 19, 0, 0, 0, DateTimeKind.Utc), "alice.smith@example.com", "Alice", "Smith", "hashed_password_2", "+9876543210", "https://example.com/alice_smith_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5372) },
                    { 3, "789 Pine St, Villagetown", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5374), new DateTime(1985, 3, 20, 19, 0, 0, 0, DateTimeKind.Utc), "bob.jones@example.com", "Bob", "Jones", "hashed_password_3", "+1122334455", "https://example.com/bob_jones_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5375) },
                    { 4, "567 Elm St, Hamletsville", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5377), new DateTime(1992, 7, 13, 19, 0, 0, 0, DateTimeKind.Utc), "emily.white@example.com", "Emily", "White", "hashed_password_4", "+9988776655", "https://example.com/emily_white_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5378) },
                    { 5, "456 Oak St, Townsville", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5380), new DateTime(1985, 8, 21, 19, 0, 0, 0, DateTimeKind.Utc), "jane.smith@example.com", "Jane", "Smith", "hashed_password_15", "+0987654321", "https://example.com/jane_smith_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5380) },
                    { 6, "876 Maple St, Grovetown", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5382), new DateTime(1993, 12, 4, 19, 0, 0, 0, DateTimeKind.Utc), "sam.green@example.com", "Sam", "Green", "hashed_password_16", "+1122334455", "https://example.com/sam_green_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5383) },
                    { 7, "234 Birch St, Forestville", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5385), new DateTime(1991, 9, 17, 19, 0, 0, 0, DateTimeKind.Utc), "olivia.brown@example.com", "Olivia", "Brown", "hashed_password_17", "+9988776655", "https://example.com/olivia_brown_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5385) },
                    { 8, "789 Cedar St, Hilltop", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5388), new DateTime(1987, 2, 27, 19, 0, 0, 0, DateTimeKind.Utc), "david.miller@example.com", "David", "Miller", "hashed_password_18", "+1122334455", "https://example.com/david_miller_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5388) },
                    { 9, "345 Pine St, Valleytown", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5390), new DateTime(1994, 6, 10, 19, 0, 0, 0, DateTimeKind.Utc), "grace.turner@example.com", "Grace", "Turner", "hashed_password_19", "+9988776655", "https://example.com/grace_turner_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5390) },
                    { 10, "567 Oak St, Laketown", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5392), new DateTime(1990, 8, 6, 19, 0, 0, 0, DateTimeKind.Utc), "ryan.clark@example.com", "Ryan", "Clark", "hashed_password_20", "+1122334455", "https://example.com/ryan_clark_profile.jpg", new DateTime(2024, 2, 29, 16, 0, 15, 219, DateTimeKind.Utc).AddTicks(5393) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
