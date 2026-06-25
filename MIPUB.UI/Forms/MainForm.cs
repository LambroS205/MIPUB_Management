using System;
using System.Drawing;
using System.Windows.Forms;
using MIPUB.Models.Entities;

namespace MIPUB.UI.Forms
{
    public partial class MainForm : Form
    {
        private User _currentUser;

        public MainForm(User loggedInUser)
        {
            InitializeComponent();
            _currentUser = loggedInUser;

            // Hiển thị thông tin người dùng ở góc dưới bên trái
            lblUserInfo.Text = $"Xin chào, {_currentUser.HoTen}\nVai trò: {_currentUser.Role?.RoleName}";

            // Phân quyền (RBAC) - Chỉ Admin (RoleId = 1) mới thấy nút Quản lý Tài khoản
            if (_currentUser.RoleId != 1)
            {
                btnQuanLyTaiKhoan.Visible = false;
            }
        }

        // Hàm hỗ trợ load UserControl vào vùng Panel chính
        public void LoadControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        // Hàm reset lại màu nền của tất cả các nút ở Sidebar
        private void ResetButtonColors()
        {
            Color defaultColor = Color.FromArgb(240, 244, 248);
            btnQuanLySach.BackColor = defaultColor;
            btnQuanLyTacGia.BackColor = defaultColor;
            btnThongKe.BackColor = defaultColor;
            btnQuanLyTaiKhoan.BackColor = defaultColor;
        }

        // --- CÁC SỰ KIỆN CLICK MENU ---

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnQuanLySach.BackColor = Color.FromArgb(220, 235, 250); // Màu highlight khi được chọn
            LoadControl(new ucBookManager());
        }

        private void btnQuanLyTacGia_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnQuanLyTacGia.BackColor = Color.FromArgb(220, 235, 250);
            LoadControl(new ucAuthorManager());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnThongKe.BackColor = Color.FromArgb(220, 235, 250);
            LoadControl(new ucStatistics());
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnQuanLyTaiKhoan.BackColor = Color.FromArgb(220, 235, 250);
            LoadControl(new ucUserManager(_currentUser.Id)); // Truyền ID để chống tự xóa chính mình
        }

        // --- SỰ KIỆN HỆ THỐNG ---

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}