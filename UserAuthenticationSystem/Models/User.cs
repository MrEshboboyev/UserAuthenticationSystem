using System;
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

        private DateTime _dateOfBirth;
        [Required]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value.ToUniversalTime(); }
        }

        [Required]
        public string? Address { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? ProfilePicture { get; set; }

        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value.ToUniversalTime(); }
        }

        private DateTime _updatedAt;
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value.ToUniversalTime(); }
        }
    }
}
