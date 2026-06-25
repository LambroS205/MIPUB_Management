using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIPUB.Models.Entities;

namespace MIPUB.DAL
{
    public class UserDAL
    {
        public List<User> LayTatCaUser()
        {
            List<User> list = new List<User>();
            string query = @"SELECT u.Id, u.Username, u.FullName, u.RoleId, r.RoleName 
                             FROM Users u
                             INNER JOIN Roles r ON u.RoleId = r.Id";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Username = reader["Username"].ToString(),
                            HoTen = reader["FullName"].ToString(),
                            RoleId = Convert.ToInt32(reader["RoleId"]),
                            Role = new Role
                            {
                                Id = Convert.ToInt32(reader["RoleId"]),
                                RoleName = reader["RoleName"].ToString()
                            }
                        });
                    }
                }
            }
            return list;
        }

        public List<Role> LayTatCaRoles()
        {
            List<Role> list = new List<Role>();
            string query = "SELECT * FROM Roles";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Role
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            RoleName = reader["RoleName"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool KiemTraTonTai(string username, int excludeId = 0)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Id != @ExcludeId";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@ExcludeId", excludeId);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void ThemUser(User user)
        {
            string query = "INSERT INTO Users (Username, PasswordHash, FullName, RoleId) VALUES (@Username, @PasswordHash, @FullName, @RoleId)";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@FullName", user.HoTen);
                cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CapNhatUser(User user, bool updatePassword)
        {
            string query = "UPDATE Users SET Username = @Username, FullName = @FullName, RoleId = @RoleId";
            if (updatePassword)
            {
                query += ", PasswordHash = @PasswordHash";
            }
            query += " WHERE Id = @Id";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@FullName", user.HoTen);
                cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                if (updatePassword)
                {
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaUser(int id)
        {
            string query = "DELETE FROM Users WHERE Id = @Id";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}