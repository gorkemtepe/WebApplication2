using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string Username { get; set; }
        public bool Locked { get; set; } = false;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public string? ProfileImageFileName { get; set; } = "no-image.jpg";
        public string Role { get; set; } = "user";
    }
}
