using System;

namespace MIPUB.Models.Entities
{
    // Class trừu tượng (Abstraction)
    public abstract class Nguoi
    {
        // Tính đóng gói (Encapsulation)
        private int _id;
        private string _hoTen;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set
            {
                // Validation: Không cho phép họ tên trống
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được để trống.");
                _hoTen = value;
            }
        }

        protected Nguoi() { }

        protected Nguoi(int id, string hoTen)
        {
            Id = id;
            HoTen = hoTen;
        }

        // Phương thức ảo để class con có thể ghi đè (Tiền đề cho Đa hình)
        public virtual string LayThongTin()
        {
            return $"ID: {Id}, Họ tên: {HoTen}";
        }
    }
}