using System.Text.RegularExpressions;

namespace MIPUB.Models.Entities
{
    // Kế thừa: Sách điện tử là một loại Sách
    public class SachDienTu : Sach
    {
        public double DungLuongMB { get; set; }
        public string DinhDang { get; set; } // PDF, EPUB...

        public SachDienTu()
        {
            LoaiSach = "SachDienTu"; // Gán loại sách mặc định
        }

        // Đa hình: Triển khai chi tiết cách hiển thị của Sách Điện Tử
        public override string HienThiThongTin()
        {
            return $"[Ebook] Mã: {MaSach} | Tiêu đề: {TieuDe} | Năm XB: {NamXuatBan} | Dung lượng: {DungLuongMB}MB | Định dạng: {DinhDang}";
        }
    }
}