using System.Collections.Generic;
using MIPUB.Models.Entities;

namespace MIPUB.Models.Interfaces
{
    // Thể hiện tính Trừu tượng (Abstraction)
    public interface IQuanLySach
    {
        void ThemSach(Sach sach);
        void CapNhatSach(Sach sach);
        void XoaSach(int id);
        Sach TimKiemTheoMa(string maSach);
        List<Sach> LayTatCaSach();
        List<Sach> TimKiemSachtheoTieuDe(string tuKhoa);
    }
}