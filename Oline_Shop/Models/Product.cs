using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oline_Shop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public String ProductName { get; set; }

        public String Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public String Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int StouckQuantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        // Foreign Key
        public Category category { get; set; }
    }
}
