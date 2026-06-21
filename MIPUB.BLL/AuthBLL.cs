using System;
using System.Security.Cryptography;
using System.Text;
using MIPUB.DAL;
using MIPUB.Models.Entities;

namespace MIPUB.BLL
{
    public class AuthBLL
    {
        private AuthDAL _authDAL = new AuthDAL();

        // Thuật toán Hash SHA-256
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

        public User DangNhap(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Tài khoản và mật khẩu không được để trống!");
            }

            User user = _authDAL.LayUserTheoUsername(username);
            if (user == null)
            {
                throw new Exception("Tài khoản không tồn tại!");
            }

            // Kiểm tra mật khẩu (So sánh hash)
            string hashInput = ComputeSha256Hash(password);
            if (user.PasswordHash != hashInput)
            {
                throw new Exception("Mật khẩu không chính xác!");
            }

            return user; // Đăng nhập thành công
        }
    }
}