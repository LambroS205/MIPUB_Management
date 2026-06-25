using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using MIPUB.DAL;
using MIPUB.Models.Entities;

namespace MIPUB.BLL
{
    public class UserBLL
    {
        private UserDAL _userDAL = new UserDAL();

        // Hàm Hash dùng chung
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public List<User> LayTatCaUser()
        {
            return _userDAL.LayTatCaUser();
        }

        public List<Role> LayTatCaRoles()
        {
            return _userDAL.LayTatCaRoles();
        }

        public void ThemUser(User user, string plainPassword)
        {
            if (string.IsNullOrWhiteSpace(user.Username)) throw new Exception("Username không được để trống.");
            if (string.IsNullOrWhiteSpace(plainPassword)) throw new Exception("Mật khẩu không được để trống.");
            if (_userDAL.KiemTraTonTai(user.Username)) throw new Exception("Tên đăng nhập đã tồn tại.");

            user.PasswordHash = ComputeSha256Hash(plainPassword);
            _userDAL.ThemUser(user);
        }

        public void CapNhatUser(User user, string plainPassword)
        {
            if (string.IsNullOrWhiteSpace(user.Username)) throw new Exception("Username không được để trống.");
            if (_userDAL.KiemTraTonTai(user.Username, user.Id)) throw new Exception("Tên đăng nhập đã tồn tại.");

            bool updatePassword = !string.IsNullOrWhiteSpace(plainPassword);
            if (updatePassword)
            {
                user.PasswordHash = ComputeSha256Hash(plainPassword);
            }

            _userDAL.CapNhatUser(user, updatePassword);
        }

        public void XoaUser(int userId, int currentLoggedInUserId)
        {
            if (userId == currentLoggedInUserId)
            {
                throw new Exception("Bạn không thể tự xóa tài khoản của chính mình khi đang đăng nhập!");
            }
            _userDAL.XoaUser(userId);
        }
    }
}