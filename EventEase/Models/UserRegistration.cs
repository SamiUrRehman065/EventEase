using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, ErrorMessage = "Name must be 50 characters or fewer")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        public string SelectedEventId { get; set; } = string.Empty;
    }
}