namespace Oline_Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String Description { get; set; }
        public String Price { get; set; }
        public int StouckQuantity { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
