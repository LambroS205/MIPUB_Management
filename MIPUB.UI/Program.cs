using System;
using System.Windows.Forms;
using MIPUB.UI.Forms;

namespace MIPUB.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Khởi chạy Form Đăng Nhập
            Application.Run(new LoginForm());
        }
    }
}