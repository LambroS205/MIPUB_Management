using System;
using System.Collections.Generic;
using MIPUB.DAL;
using MIPUB.Models.Entities;

namespace MIPUB.BLL
{
    public class TacGiaBLL
    {
        private TacGiaDAL _tacGiaDAL = new TacGiaDAL();
        private SachDAL _sachDAL = new SachDAL(); // Tích hợp SachDAL để kiểm tra ràng buộc

        public List<TacGia> LayTatCaTacGia()
        {
            return _tacGiaDAL.LayTatCaTacGia();
        }

        public void ThemTacGia(TacGia tacGia)
        {
            if (string.IsNullOrWhiteSpace(tacGia.HoTen))
                throw new Exception("Họ tên tác giả không được để trống!");

            _tacGiaDAL.ThemTacGia(tacGia);
        }

        public void CapNhatTacGia(TacGia tacGia)
        {
            if (string.IsNullOrWhiteSpace(tacGia.HoTen))
                throw new Exception("Họ tên tác giả không được để trống!");

            _tacGiaDAL.CapNhatTacGia(tacGia);
        }

        public void XoaTacGia(int id)
        {
            // Logic nghiệp vụ: Kiểm tra xem tác giả này có sách nào trong DB chưa
            var dsSach = _sachDAL.LaySachTheoTacGia(id);
            if (dsSach.Count > 0)
            {
                throw new Exception($"Không thể xóa tác giả này vì đang có {dsSach.Count} đầu sách liên kết trong hệ thống!");
            }

            _tacGiaDAL.XoaTacGia(id);
        }

        public TacGia TimTacGiaNhieuSachNhat()
        {
            return _tacGiaDAL.TimTacGiaNhieuSachNhat();
        }
    }
}