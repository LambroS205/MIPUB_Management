using MIPUB.DAL;
using MIPUB.Models.Entities;

namespace MIPUB.BLL
{
    public class TacGiaBLL
    {
        private TacGiaDAL _tacGiaDAL = new TacGiaDAL();

        // Trả về tác giả có số lượng sách xuất bản nhiều nhất
        public TacGia TimTacGiaNhieuSachNhat()
        {
            return _tacGiaDAL.TimTacGiaNhieuSachNhat();
        }
    }
}