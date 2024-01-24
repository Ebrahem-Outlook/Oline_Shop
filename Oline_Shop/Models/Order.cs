namespace Oline_Shop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public String Status { get; set; }

        // Foreign Key
        public User User { get; set; }
    }
}
