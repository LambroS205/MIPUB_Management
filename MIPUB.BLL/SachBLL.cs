using System;
using System.Collections.Generic;
using MIPUB.DAL;
using MIPUB.Models.Entities;
using MIPUB.Models.Interfaces;

namespace MIPUB.BLL
{
    // BLL triển khai Interface (Abstraction) đã thiết kế ở Models
    public class SachBLL : IQuanLySach
    {
        private SachDAL _sachDAL = new SachDAL();

        public List<Sach> LayTatCaSach()
        {
            return _sachDAL.LayTatCaSach();
        }

        public void ThemSach(Sach sach)
        {
            // Logic nghiệp vụ: Kiểm tra mã sách đã tồn tại chưa
            Sach s = _sachDAL.TimKiemTheoMa(sach.MaSach);
            if (s != null)
            {
                throw new Exception("Mã sách này đã tồn tại trong hệ thống. Vui lòng nhập mã khác.");
            }

            // Validate sơ bộ năm xuất bản
            if (sach.NamXuatBan > DateTime.Now.Year)
            {
                throw new Exception("Năm xuất bản không hợp lệ.");
            }

            _sachDAL.ThemSach(sach);
        }

        public void CapNhatSach(Sach sach)
        {
            // Bài toán yêu cầu mức cơ bản, nếu cần có thể triển khai DAL update
            throw new NotImplementedException("Chức năng cập nhật đang được bảo trì.");
        }

        public void XoaSach(int id)
        {
            throw new NotImplementedException("Chức năng xóa đang được bảo trì.");
        }

        public Sach TimKiemTheoMa(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach)) return null;
            return _sachDAL.TimKiemTheoMa(maSach);
        }

        public List<Sach> TimKiemSachtheoTieuDe(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return LayTatCaSach();
            return _sachDAL.TimKiemSachtheoTieuDe(tuKhoa);
        }

        public int DemSachTheoNam(int nam)
        {
            if (nam <= 0) throw new Exception("Năm không hợp lệ!");
            return _sachDAL.DemSachTheoNam(nam);
        }

        public List<Sach> LaySachTheoTacGia(int tacGiaId)
        {
            return _sachDAL.LaySachTheoTacGia(tacGiaId);
        }
    }
}