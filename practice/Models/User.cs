using System.ComponentModel.DataAnnotations;

namespace practice.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public enum Gender
    {
        Male,Female
    }
}
