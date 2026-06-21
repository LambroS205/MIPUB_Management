using System;
using Microsoft.Data.SqlClient;
using MIPUB.Models.Entities;

namespace MIPUB.DAL
{
    public class AuthDAL
    {
        public User LayUserTheoUsername(string username)
        {
            User user = null;
            string query = @"SELECT u.Id, u.Username, u.PasswordHash, u.FullName, u.RoleId, r.RoleName 
                             FROM Users u
                             INNER JOIN Roles r ON u.RoleId = r.Id
                             WHERE u.Username = @Username";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Username = reader["Username"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            HoTen = reader["FullName"].ToString(),
                            RoleId = Convert.ToInt32(reader["RoleId"]),
                            Role = new Role
                            {
                                Id = Convert.ToInt32(reader["RoleId"]),
                                RoleName = reader["RoleName"].ToString()
                            }
                        };
                    }
                }
            }
            return user;
        }
    }
}