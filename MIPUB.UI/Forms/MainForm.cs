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

            lblUserInfo.Text = $"Xin chào, {_currentUser.HoTen}\nVai trò: {_currentUser.Role?.RoleName}";

            // Phân quyền (RBAC) - Chỉ Admin mới thấy Quản lý Tài khoản
            if (_currentUser.RoleId != 1)
            {
                btnQuanLyTaiKhoan.Visible = false;
            }
        }

        public void LoadControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void ResetButtonColors()
        {
            btnQuanLySach.BackColor = Color.FromArgb(240, 244, 248);
            btnThongKe.BackColor = Color.FromArgb(240, 244, 248);
            btnQuanLyTaiKhoan.BackColor = Color.FromArgb(240, 244, 248);
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnQuanLySach.BackColor = Color.FromArgb(220, 235, 250);
            LoadControl(new ucBookManager());
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Hide();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}