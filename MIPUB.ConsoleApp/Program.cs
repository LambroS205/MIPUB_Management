using System;
using System.Collections.Generic;
using MIPUB.BLL;
using MIPUB.Models.Entities;

namespace MIPUB.ConsoleApp
{
    class Program
    {
        static AuthBLL _authBLL = new AuthBLL();
        static SachBLL _sachBLL = new SachBLL();
        static TacGiaBLL _tacGiaBLL = new TacGiaBLL();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=============================================");
            Console.WriteLine("       HỆ THỐNG QUẢN LÝ SÁCH MIPUB (CLI)     ");
            Console.WriteLine("=============================================");

            User currentUser = null;

            // Vòng lặp Đăng nhập
            while (currentUser == null)
            {
                try
                {
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = ReadPassword();

                    currentUser = _authBLL.DangNhap(username, password);
                    Console.WriteLine($"\n=> Đăng nhập thành công! Xin chào {currentUser.HoTen} ({currentUser.Role?.RoleName}).\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[LỖI] {ex.Message}. Vui lòng thử lại!\n");
                }
            }

            // Vòng lặp Menu chính
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("================ MENU CHÍNH =================");
                Console.WriteLine("1. Hiển thị tất cả đầu sách");
                Console.WriteLine("2. Tìm kiếm sách theo tiêu đề");
                Console.WriteLine("3. Thêm sách mới");
                Console.WriteLine("4. Thống kê số lượng sách theo năm");
                Console.WriteLine("5. Tìm tác giả nhiều sách nhất");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("=============================================");
                Console.Write("Chọn chức năng (0-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        HienThiDanhSachSach();
                        break;
                    case "2":
                        TimKiemSach();
                        break;
                    case "3":
                        ThemSachMoi();
                        break;
                    case "4":
                        ThongKeTheoNam();
                        break;
                    case "5":
                        TimTacGiaNhieuSachNhat();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("[!] Lựa chọn không hợp lệ.");
                        break;
                }
                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // --- CÁC HÀM XỬ LÝ NGHIỆP VỤ (Gọi BLL) ---

        static void HienThiDanhSachSach(List<Sach> danhSach = null)
        {
            try
            {
                if (danhSach == null) danhSach = _sachBLL.LayTatCaSach();

                Console.WriteLine("--- DANH SÁCH SÁCH ---");
                if (danhSach.Count == 0)
                {
                    Console.WriteLine("Không có dữ liệu.");
                    return;
                }

                foreach (var sach in danhSach)
                {
                    // TÍNH ĐA HÌNH (Polymorphism): Tự động gọi đúng phương thức HienThiThongTin() của SachIn hoặc SachDienTu
                    Console.WriteLine(sach.HienThiThongTin());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LỖI] {ex.Message}");
            }
        }

        static void TimKiemSach()
        {
            Console.Write("Nhập từ khóa tiêu đề sách: ");
            string tuKhoa = Console.ReadLine();
            var ketQua = _sachBLL.TimKiemSachtheoTieuDe(tuKhoa);

            Console.WriteLine($"\nTìm thấy {ketQua.Count} kết quả:");
            HienThiDanhSachSach(ketQua);
        }

        static void ThongKeTheoNam()
        {
            Console.Write("Nhập năm cần thống kê: ");
            if (int.TryParse(Console.ReadLine(), out int nam))
            {
                try
                {
                    int count = _sachBLL.DemSachTheoNam(nam);
                    Console.WriteLine($"=> Có {count} đầu sách được xuất bản trong năm {nam}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[LỖI] {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("[!] Năm không hợp lệ.");
            }
        }

        static void TimTacGiaNhieuSachNhat()
        {
            try
            {
                var tacGia = _tacGiaBLL.TimTacGiaNhieuSachNhat();
                if (tacGia != null)
                {
                    var dsSach = _sachBLL.LaySachTheoTacGia(tacGia.Id);
                    Console.WriteLine("--- TÁC GIẢ CÓ NHIỀU SÁCH NHẤT ---");
                    Console.WriteLine($"ID: {tacGia.Id} | Họ tên: {tacGia.HoTen}");
                    Console.WriteLine($"Tiểu sử: {tacGia.TieuSu}");
                    Console.WriteLine($"=> Tổng số sách: {dsSach.Count}");
                    Console.WriteLine("Các tác phẩm:");
                    foreach (var s in dsSach)
                    {
                        Console.WriteLine($"  - {s.TieuDe} ({s.NamXuatBan})");
                    }
                }
                else
                {
                    Console.WriteLine("Chưa có dữ liệu tác giả.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LỖI] {ex.Message}");
            }
        }

        static void ThemSachMoi()
        {
            try
            {
                Console.WriteLine("--- THÊM SÁCH MỚI ---");
                Console.Write("Chọn loại sách (1 - Sách In, 2 - Ebook): ");
                string loai = Console.ReadLine();

                Sach newSach;
                if (loai == "1")
                {
                    newSach = new SachIn();
                    Console.Write("Số trang: ");
                    ((SachIn)newSach).SoTrang = int.Parse(Console.ReadLine());
                    Console.Write("Kích thước (vd: 13x20): ");
                    ((SachIn)newSach).KichThuoc = Console.ReadLine();
                }
                else if (loai == "2")
                {
                    newSach = new SachDienTu();
                    Console.Write("Dung lượng (MB): ");
                    ((SachDienTu)newSach).DungLuongMB = double.Parse(Console.ReadLine());
                    Console.Write("Định dạng (PDF/EPUB): ");
                    ((SachDienTu)newSach).DinhDang = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("[!] Lựa chọn không hợp lệ.");
                    return;
                }

                Console.Write("Mã sách: "); newSach.MaSach = Console.ReadLine();
                Console.Write("Tiêu đề: "); newSach.TieuDe = Console.ReadLine();
                Console.Write("Năm XB: "); newSach.NamXuatBan = int.Parse(Console.ReadLine());
                Console.Write("ID Tác giả: "); newSach.TacGiaId = int.Parse(Console.ReadLine());

                _sachBLL.ThemSach(newSach);
                Console.WriteLine("=> Thêm sách thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LỖI] Thêm sách thất bại: {ex.Message}");
            }
        }

        // Helper để ẩn mật khẩu khi nhập trên Console
        static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}