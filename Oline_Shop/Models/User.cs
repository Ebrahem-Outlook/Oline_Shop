namespace Oline_Shop.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String PasswordHash { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }

    }
}
