﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserAuthenticationSystem.Data;

#nullable disable

namespace UserAuthenticationSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserAuthenticationSystem.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Cityville",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8337),
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PasswordHash = "hashed_password_1",
                            PhoneNumber = "+1234567890",
                            ProfilePicture = "https://example.com/john_doe_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8347),
                            Username = "john_doe"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak St, Townsville",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8350),
                            DateOfBirth = new DateTime(1988, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice.smith@example.com",
                            FirstName = "Alice",
                            LastName = "Smith",
                            PasswordHash = "hashed_password_2",
                            PhoneNumber = "+9876543210",
                            ProfilePicture = "https://example.com/alice_smith_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8351),
                            Username = "alice_smith"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Pine St, Villagetown",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8353),
                            DateOfBirth = new DateTime(1985, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.jones@example.com",
                            FirstName = "Bob",
                            LastName = "Jones",
                            PasswordHash = "hashed_password_3",
                            PhoneNumber = "+1122334455",
                            ProfilePicture = "https://example.com/bob_jones_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8353),
                            Username = "bob_jones"
                        },
                        new
                        {
                            Id = 4,
                            Address = "567 Elm St, Hamletsville",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8356),
                            DateOfBirth = new DateTime(1992, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emily.white@example.com",
                            FirstName = "Emily",
                            LastName = "White",
                            PasswordHash = "hashed_password_4",
                            PhoneNumber = "+9988776655",
                            ProfilePicture = "https://example.com/emily_white_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8356),
                            Username = "emily_white"
                        },
                        new
                        {
                            Id = 5,
                            Address = "456 Oak St, Townsville",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8358),
                            DateOfBirth = new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PasswordHash = "hashed_password_15",
                            PhoneNumber = "+0987654321",
                            ProfilePicture = "https://example.com/jane_smith_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8358),
                            Username = "jane_smith"
                        },
                        new
                        {
                            Id = 16,
                            Address = "876 Maple St, Grovetown",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8360),
                            DateOfBirth = new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sam.green@example.com",
                            FirstName = "Sam",
                            LastName = "Green",
                            PasswordHash = "hashed_password_16",
                            PhoneNumber = "+1122334455",
                            ProfilePicture = "https://example.com/sam_green_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8361),
                            Username = "sam_green"
                        },
                        new
                        {
                            Id = 17,
                            Address = "234 Birch St, Forestville",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8362),
                            DateOfBirth = new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "olivia.brown@example.com",
                            FirstName = "Olivia",
                            LastName = "Brown",
                            PasswordHash = "hashed_password_17",
                            PhoneNumber = "+9988776655",
                            ProfilePicture = "https://example.com/olivia_brown_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8363),
                            Username = "olivia_brown"
                        },
                        new
                        {
                            Id = 18,
                            Address = "789 Cedar St, Hilltop",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8365),
                            DateOfBirth = new DateTime(1987, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "david.miller@example.com",
                            FirstName = "David",
                            LastName = "Miller",
                            PasswordHash = "hashed_password_18",
                            PhoneNumber = "+1122334455",
                            ProfilePicture = "https://example.com/david_miller_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8366),
                            Username = "david_miller"
                        },
                        new
                        {
                            Id = 19,
                            Address = "345 Pine St, Valleytown",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8368),
                            DateOfBirth = new DateTime(1994, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "grace.turner@example.com",
                            FirstName = "Grace",
                            LastName = "Turner",
                            PasswordHash = "hashed_password_19",
                            PhoneNumber = "+9988776655",
                            ProfilePicture = "https://example.com/grace_turner_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8368),
                            Username = "grace_turner"
                        },
                        new
                        {
                            Id = 20,
                            Address = "567 Oak St, Laketown",
                            CreatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8370),
                            DateOfBirth = new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ryan.clark@example.com",
                            FirstName = "Ryan",
                            LastName = "Clark",
                            PasswordHash = "hashed_password_20",
                            PhoneNumber = "+1122334455",
                            ProfilePicture = "https://example.com/ryan_clark_profile.jpg",
                            UpdatedAt = new DateTime(2024, 2, 28, 20, 6, 27, 116, DateTimeKind.Local).AddTicks(8370),
                            Username = "ryan_clark"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
