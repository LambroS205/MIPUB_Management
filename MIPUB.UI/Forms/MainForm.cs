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

            // Hiển thị thông tin người dùng
            lblUserInfo.Text = $"Xin chào, {_currentUser.HoTen}\nVai trò: {_currentUser.Role?.RoleName}";

            // Phân quyền cơ bản (RBAC)
            if (_currentUser.RoleId != 1) // 1 là Admin, 2 là Nhân viên
            {
                // Nếu là nhân viên, có thể ẩn bớt một số chức năng đặc quyền nếu cần
                // VD: btnCaiDat.Visible = false;
            }
        }

        // Helper để load UserControl vào Panel chính
        public void LoadControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            // Reset màu các nút
            ResetButtonColors();
            btnQuanLySach.BackColor = Color.FromArgb(220, 235, 250); // Highlight

            // Đã bỏ comment để Load form
            LoadControl(new ucBookManager());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnThongKe.BackColor = Color.FromArgb(220, 235, 250);

            // Đã bỏ comment để Load form
            LoadControl(new ucStatistics());
        }

        private void ResetButtonColors()
        {
            btnQuanLySach.BackColor = Color.FromArgb(240, 244, 248);
            btnThongKe.BackColor = Color.FromArgb(240, 244, 248);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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