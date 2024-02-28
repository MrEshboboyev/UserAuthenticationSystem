using Microsoft.EntityFrameworkCore;
using UserAuthenticationSystem.Models;

namespace UserAuthenticationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        Username = "john_doe",
                        Email = "john.doe@example.com",
                        PasswordHash = "hashed_password_1",
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth = new DateTime(1990, 5, 15),
                        Address = "123 Main St, Cityville",
                        PhoneNumber = "+1234567890",
                        ProfilePicture = "https://example.com/john_doe_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 2,
                        Username = "alice_smith",
                        Email = "alice.smith@example.com",
                        PasswordHash = "hashed_password_2",
                        FirstName = "Alice",
                        LastName = "Smith",
                        DateOfBirth = new DateTime(1988, 11, 8),
                        Address = "456 Oak St, Townsville",
                        PhoneNumber = "+9876543210",
                        ProfilePicture = "https://example.com/alice_smith_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    // Repeat similar blocks for additional users
                    new User
                    {
                        Id = 3,
                        Username = "bob_jones",
                        Email = "bob.jones@example.com",
                        PasswordHash = "hashed_password_3",
                        FirstName = "Bob",
                        LastName = "Jones",
                        DateOfBirth = new DateTime(1985, 3, 21),
                        Address = "789 Pine St, Villagetown",
                        PhoneNumber = "+1122334455",
                        ProfilePicture = "https://example.com/bob_jones_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 4,
                        Username = "emily_white",
                        Email = "emily.white@example.com",
                        PasswordHash = "hashed_password_4",
                        FirstName = "Emily",
                        LastName = "White",
                        DateOfBirth = new DateTime(1992, 7, 14),
                        Address = "567 Elm St, Hamletsville",
                        PhoneNumber = "+9988776655",
                        ProfilePicture = "https://example.com/emily_white_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 5,
                        Username = "jane_smith",
                        Email = "jane.smith@example.com",
                        PasswordHash = "hashed_password_15",
                        FirstName = "Jane",
                        LastName = "Smith",
                        DateOfBirth = new DateTime(1985, 8, 22),
                        Address = "456 Oak St, Townsville",
                        PhoneNumber = "+0987654321",
                        ProfilePicture = "https://example.com/jane_smith_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 16,
                        Username = "sam_green",
                        Email = "sam.green@example.com",
                        PasswordHash = "hashed_password_16",
                        FirstName = "Sam",
                        LastName = "Green",
                        DateOfBirth = new DateTime(1993, 12, 5),
                        Address = "876 Maple St, Grovetown",
                        PhoneNumber = "+1122334455",
                        ProfilePicture = "https://example.com/sam_green_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 17,
                        Username = "olivia_brown",
                        Email = "olivia.brown@example.com",
                        PasswordHash = "hashed_password_17",
                        FirstName = "Olivia",
                        LastName = "Brown",
                        DateOfBirth = new DateTime(1991, 9, 18),
                        Address = "234 Birch St, Forestville",
                        PhoneNumber = "+9988776655",
                        ProfilePicture = "https://example.com/olivia_brown_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 18,
                        Username = "david_miller",
                        Email = "david.miller@example.com",
                        PasswordHash = "hashed_password_18",
                        FirstName = "David",
                        LastName = "Miller",
                        DateOfBirth = new DateTime(1987, 2, 28),
                        Address = "789 Cedar St, Hilltop",
                        PhoneNumber = "+1122334455",
                        ProfilePicture = "https://example.com/david_miller_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 19,
                        Username = "grace_turner",
                        Email = "grace.turner@example.com",
                        PasswordHash = "hashed_password_19",
                        FirstName = "Grace",
                        LastName = "Turner",
                        DateOfBirth = new DateTime(1994, 6, 11),
                        Address = "345 Pine St, Valleytown",
                        PhoneNumber = "+9988776655",
                        ProfilePicture = "https://example.com/grace_turner_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new User
                    {
                        Id = 20,
                        Username = "ryan_clark",
                        Email = "ryan.clark@example.com",
                        PasswordHash = "hashed_password_20",
                        FirstName = "Ryan",
                        LastName = "Clark",
                        DateOfBirth = new DateTime(1990, 8, 7),
                        Address = "567 Oak St, Laketown",
                        PhoneNumber = "+1122334455",
                        ProfilePicture = "https://example.com/ryan_clark_profile.jpg",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                );
        }
    }
}
