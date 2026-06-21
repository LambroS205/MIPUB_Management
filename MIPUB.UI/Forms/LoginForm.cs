using Microsoft.Data.SqlClient;
using MIPUB.BLL;
using MIPUB.Models.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MIPUB.UI.Forms
{
    public partial class LoginForm : Form
    {
        private AuthBLL _authBLL = new AuthBLL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Gọi BLL để xử lý đăng nhập
                User loggedInUser = _authBLL.DangNhap(username, password);

                if (loggedInUser != null)
                {
                    // Chuyển sang MainForm và truyền thông tin user để phân quyền
                    MainForm mainForm = new MainForm(loggedInUser);
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}