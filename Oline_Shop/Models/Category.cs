using System.ComponentModel.DataAnnotations;

namespace Oline_Shop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public String CategoryName { get; set; }
    }
}
