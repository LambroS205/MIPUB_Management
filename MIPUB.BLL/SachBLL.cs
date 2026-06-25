using System;
using System.Collections.Generic;
using MIPUB.DAL;
using MIPUB.Models.Entities;
using MIPUB.Models.Interfaces;

namespace MIPUB.BLL
{
    public class SachBLL : IQuanLySach
    {
        private SachDAL _sachDAL = new SachDAL();

        public List<Sach> LayTatCaSach()
        {
            return _sachDAL.LayTatCaSach();
        }

        public void ThemSach(Sach sach)
        {
            Sach s = _sachDAL.TimKiemTheoMa(sach.MaSach);
            if (s != null) throw new Exception("Mã sách này đã tồn tại trong hệ thống. Vui lòng nhập mã khác.");

            if (sach.NamXuatBan > DateTime.Now.Year) throw new Exception("Năm xuất bản không hợp lệ.");

            _sachDAL.ThemSach(sach);
        }

        // --- ĐÃ IMPLEMENT CHỨC NĂNG CẬP NHẬT ---
        public void CapNhatSach(Sach sach)
        {
            if (sach.NamXuatBan > DateTime.Now.Year) throw new Exception("Năm xuất bản không hợp lệ.");
            _sachDAL.CapNhatSach(sach);
        }

        // --- ĐÃ IMPLEMENT CHỨC NĂNG XÓA ---
        public void XoaSach(int id)
        {
            if (id <= 0) throw new Exception("ID sách không hợp lệ.");
            _sachDAL.XoaSach(id);
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