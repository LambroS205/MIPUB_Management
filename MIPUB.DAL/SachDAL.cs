using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MIPUB.Models.Entities;

namespace MIPUB.DAL
{
    public class SachDAL
    {
        // Helper map SqlDataReader sang đối tượng Sach
        private Sach MapReaderToSach(SqlDataReader reader)
        {
            Sach sach;
            string loaiSach = reader["LoaiSach"].ToString();

            if (loaiSach == "SachIn")
            {
                sach = new SachIn
                {
                    SoTrang = reader["SoTrang"] != DBNull.Value ? Convert.ToInt32(reader["SoTrang"]) : 0,
                    KichThuoc = reader["KichThuoc"].ToString()
                };
            }
            else // SachDienTu
            {
                sach = new SachDienTu
                {
                    DungLuongMB = reader["DungLuongMB"] != DBNull.Value ? Convert.ToDouble(reader["DungLuongMB"]) : 0,
                    DinhDang = reader["DinhDang"].ToString()
                };
            }

            sach.Id = Convert.ToInt32(reader["Id"]);
            sach.MaSach = reader["MaSach"].ToString();
            sach.TieuDe = reader["TieuDe"].ToString();
            sach.NamXuatBan = Convert.ToInt32(reader["NamXuatBan"]);
            sach.TacGiaId = Convert.ToInt32(reader["TacGiaId"]);
            sach.NhaXuatBan = reader["NhaXuatBan"].ToString();

            if (HasColumn(reader, "HoTenTacGia") && reader["HoTenTacGia"] != DBNull.Value)
            {
                sach.TacGia = new TacGia { Id = sach.TacGiaId, HoTen = reader["HoTenTacGia"].ToString() };
            }
            return sach;
        }

        private bool HasColumn(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        public List<Sach> LayTatCaSach()
        {
            List<Sach> dsSach = new List<Sach>();
            string query = @"SELECT s.*, t.HoTen as HoTenTacGia FROM Sach s INNER JOIN TacGia t ON s.TacGiaId = t.Id";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) dsSach.Add(MapReaderToSach(reader));
                }
            }
            return dsSach;
        }

        public Sach TimKiemTheoMa(string maSach)
        {
            Sach sach = null;
            string query = "SELECT * FROM Sach WHERE MaSach = @MaSach";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) sach = MapReaderToSach(reader);
                }
            }
            return sach;
        }

        public void ThemSach(Sach sach)
        {
            string query = @"INSERT INTO Sach (MaSach, TieuDe, NamXuatBan, TacGiaId, NhaXuatBan, LoaiSach, SoTrang, KichThuoc, DungLuongMB, DinhDang)
                             VALUES (@MaSach, @TieuDe, @NamXuatBan, @TacGiaId, @NhaXuatBan, @LoaiSach, @SoTrang, @KichThuoc, @DungLuongMB, @DinhDang)";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SetSachParameters(cmd, sach);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // --- CÁC HÀM MỚI ĐƯỢC BỔ SUNG ĐỂ HOÀN THIỆN CRUD ---

        public void CapNhatSach(Sach sach)
        {
            string query = @"UPDATE Sach 
                             SET TieuDe = @TieuDe, NamXuatBan = @NamXuatBan, TacGiaId = @TacGiaId, 
                                 NhaXuatBan = @NhaXuatBan, LoaiSach = @LoaiSach, SoTrang = @SoTrang, 
                                 KichThuoc = @KichThuoc, DungLuongMB = @DungLuongMB, DinhDang = @DinhDang
                             WHERE Id = @Id";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", sach.Id);
                SetSachParameters(cmd, sach); // Tái sử dụng hàm set params
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaSach(int id)
        {
            string query = "DELETE FROM Sach WHERE Id = @Id";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void SetSachParameters(SqlCommand cmd, Sach sach)
        {
            cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
            cmd.Parameters.AddWithValue("@TieuDe", sach.TieuDe);
            cmd.Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan);
            cmd.Parameters.AddWithValue("@TacGiaId", sach.TacGiaId);
            cmd.Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan);
            cmd.Parameters.AddWithValue("@LoaiSach", sach.LoaiSach);

            if (sach is SachIn sIn)
            {
                cmd.Parameters.AddWithValue("@SoTrang", sIn.SoTrang);
                cmd.Parameters.AddWithValue("@KichThuoc", sIn.KichThuoc ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DungLuongMB", DBNull.Value);
                cmd.Parameters.AddWithValue("@DinhDang", DBNull.Value);
            }
            else if (sach is SachDienTu sEbook)
            {
                cmd.Parameters.AddWithValue("@SoTrang", DBNull.Value);
                cmd.Parameters.AddWithValue("@KichThuoc", DBNull.Value);
                cmd.Parameters.AddWithValue("@DungLuongMB", sEbook.DungLuongMB);
                cmd.Parameters.AddWithValue("@DinhDang", sEbook.DinhDang ?? (object)DBNull.Value);
            }
        }

        // Các hàm tìm kiếm & thống kê giữ nguyên
        public List<Sach> TimKiemSachtheoTieuDe(string tuKhoa)
        {
            List<Sach> dsSach = new List<Sach>();
            string query = @"SELECT s.*, t.HoTen as HoTenTacGia FROM Sach s INNER JOIN TacGia t ON s.TacGiaId = t.Id WHERE s.TieuDe LIKE @TuKhoa";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) dsSach.Add(MapReaderToSach(reader));
                }
            }
            return dsSach;
        }

        public List<Sach> LaySachTheoTacGia(int tacGiaId)
        {
            List<Sach> dsSach = new List<Sach>();
            string query = "SELECT * FROM Sach WHERE TacGiaId = @TacGiaId";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TacGiaId", tacGiaId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) dsSach.Add(MapReaderToSach(reader));
                }
            }
            return dsSach;
        }

        public int DemSachTheoNam(int nam)
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM Sach WHERE NamXuatBan = @Nam";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nam", nam);
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }
    }
}