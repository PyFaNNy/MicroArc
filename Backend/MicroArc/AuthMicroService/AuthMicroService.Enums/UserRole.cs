using System.Runtime.Serialization;

namespace AuthMicroService.Enums
{
    public enum UserRole
    {
        [EnumMember(Value = "admin")]
        Admin = 0,

        [EnumMember(Value = "doctor")]
        User = 1,
    }
}
