using System;
using Microsoft.Data.SqlClient;
using MIPUB.Models.Entities;

namespace MIPUB.DAL
{
    public class TacGiaDAL
    {
        public TacGia TimTacGiaNhieuSachNhat()
        {
            TacGia tacGia = null;
            // Dùng GROUP BY để tìm tác giả có count(Sach) lớn nhất
            string query = @"SELECT TOP 1 t.Id, t.HoTen, t.TieuSu, COUNT(s.Id) AS SoLuongSach
                             FROM TacGia t
                             JOIN Sach s ON t.Id = s.TacGiaId
                             GROUP BY t.Id, t.HoTen, t.TieuSu
                             ORDER BY SoLuongSach DESC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tacGia = new TacGia
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            HoTen = reader["HoTen"].ToString(),
                            TieuSu = reader["TieuSu"].ToString()
                        };
                    }
                }
            }
            return tacGia;
        }
    }
}