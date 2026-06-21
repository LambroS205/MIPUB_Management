namespace MIPUB.Models.Entities
{
    // Tính kế thừa (Inheritance): Tác giả là một Người
    public class TacGia : Nguoi
    {
        public string TieuSu { get; set; }

        public TacGia() : base() { }

        public TacGia(int id, string hoTen, string tieuSu) : base(id, hoTen)
        {
            TieuSu = tieuSu;
        }

        // Tính đa hình (Polymorphism): Ghi đè phương thức hiển thị
        public override string LayThongTin()
        {
            return base.LayThongTin() + $", Tiểu sử: {TieuSu}";
        }
    }
}