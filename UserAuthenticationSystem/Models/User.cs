using System.ComponentModel.DataAnnotations;

namespace UserAuthenticationSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? ProfilePicture { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
