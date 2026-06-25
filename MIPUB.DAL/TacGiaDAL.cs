using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIPUB.Models.Entities;

namespace MIPUB.DAL
{
    public class TacGiaDAL
    {
        public List<TacGia> LayTatCaTacGia()
        {
            List<TacGia> list = new List<TacGia>();
            string query = "SELECT * FROM TacGia";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TacGia
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            HoTen = reader["HoTen"].ToString(),
                            TieuSu = reader["TieuSu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public void ThemTacGia(TacGia tacGia)
        {
            string query = "INSERT INTO TacGia (HoTen, TieuSu) VALUES (@HoTen, @TieuSu)";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", tacGia.HoTen);
                cmd.Parameters.AddWithValue("@TieuSu", tacGia.TieuSu ?? (object)DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CapNhatTacGia(TacGia tacGia)
        {
            string query = "UPDATE TacGia SET HoTen = @HoTen, TieuSu = @TieuSu WHERE Id = @Id";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", tacGia.Id);
                cmd.Parameters.AddWithValue("@HoTen", tacGia.HoTen);
                cmd.Parameters.AddWithValue("@TieuSu", tacGia.TieuSu ?? (object)DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaTacGia(int id)
        {
            string query = "DELETE FROM TacGia WHERE Id = @Id";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public TacGia TimTacGiaNhieuSachNhat()
        {
            TacGia tacGia = null;
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