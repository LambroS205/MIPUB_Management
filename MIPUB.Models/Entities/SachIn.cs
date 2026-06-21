using System.Text.RegularExpressions;

namespace MIPUB.Models.Entities
{
    // Kế thừa: Sách in là một loại Sách
    public class SachIn : Sach
    {
        public int SoTrang { get; set; }
        public string KichThuoc { get; set; }

        public SachIn()
        {
            LoaiSach = "SachIn"; // Gán loại sách mặc định
        }

        // Đa hình: Triển khai chi tiết cách hiển thị của Sách In
        public override string HienThiThongTin()
        {
            return $"[Sách In] Mã: {MaSach} | Tiêu đề: {TieuDe} | Năm XB: {NamXuatBan} | Số trang: {SoTrang} | Kích thước: {KichThuoc}";
        }
    }
}