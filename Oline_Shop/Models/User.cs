using System.ComponentModel.DataAnnotations;

namespace Oline_Shop.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public String UserName { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [StringLength(100)]
        public String PasswordHash { get; set; }

        [StringLength(100)]
        public String FullName { get; set; }

        [StringLength(255)]
        public String Address { get; set; }

        [Phone]
        public String PhoneNumber { get; set; }
    }
}
