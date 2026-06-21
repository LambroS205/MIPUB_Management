using System;

namespace MIPUB.Models.Entities
{
    // Class trừu tượng: Định nghĩa khung chuẩn cho mọi loại sách
    public abstract class Sach
    {
        // Tính đóng gói
        private string _maSach;

        public int Id { get; set; }

        public string MaSach
        {
            get { return _maSach; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mã sách không được để trống.");
                _maSach = value;
            }
        }

        public string TieuDe { get; set; }
        public int NamXuatBan { get; set; }
        public int TacGiaId { get; set; }

        // Navigation property
        public TacGia TacGia { get; set; }

        public string NhaXuatBan { get; set; } = "MIPUB";

        // Phân biệt 'SachIn' hoặc 'SachDienTu'
        public string LoaiSach { get; protected set; }

        // Phương thức trừu tượng BẮT BUỘC class con phải triển khai (Đa hình)
        public abstract string HienThiThongTin();
    }
}