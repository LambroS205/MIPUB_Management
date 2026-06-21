using System.Data;

namespace MIPUB.Models.Entities
{
    // Tính kế thừa (Inheritance): User là một Người
    public class User : Nguoi
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }

        // Navigation property liên kết với Role
        public Role Role { get; set; }

        public User() : base() { }

        // Đa hình
        public override string LayThongTin()
        {
            return base.LayThongTin() + $", Tài khoản: {Username}, Role ID: {RoleId}";
        }
    }
}