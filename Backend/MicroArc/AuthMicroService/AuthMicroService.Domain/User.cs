using AuthMicroService.Enums;

namespace AuthMicroService.Domain
{
    public class User
    {
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastLogin { get; set; }
        public UserRole Roles { get; set; }
    }
}
