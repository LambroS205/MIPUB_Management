using System;
using System.Windows.Forms;
using MIPUB.BLL;
using MIPUB.Models.Entities;

namespace MIPUB.UI.Forms
{
    public partial class ucUserManager : UserControl
    {
        private UserBLL _userBLL = new UserBLL();
        private int _selectedUserId = -1;
        private int _currentLoggedInUserId;

        public ucUserManager(int currentUserId)
        {
            InitializeComponent();
            _currentLoggedInUserId = currentUserId;
        }

        private void ucUserManager_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadData();
        }

        private void LoadRoles()
        {
            try
            {
                cbRole.DataSource = _userBLL.LayTatCaRoles();
                cbRole.DisplayMember = "RoleName";
                cbRole.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách quyền: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                dgvUsers.Rows.Clear();
                var list = _userBLL.LayTatCaUser();
                foreach (var user in list)
                {
                    dgvUsers.Rows.Add(user.Id, user.Username, user.HoTen, user.Role?.RoleName, user.RoleId);
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            _selectedUserId = -1;
            txtUsername.Clear();
            txtUsername.Enabled = true;
            txtPassword.Clear();
            txtFullName.Clear();
            if (cbRole.Items.Count > 0) cbRole.SelectedIndex = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                _selectedUserId = Convert.ToInt32(row.Cells["ColId"].Value);
                txtUsername.Text = row.Cells["ColUsername"].Value.ToString();
                txtUsername.Enabled = false; // Hạn chế đổi username
                txtFullName.Text = row.Cells["ColFullName"].Value.ToString();
                cbRole.SelectedValue = Convert.ToInt32(row.Cells["ColRoleId"].Value);

                txtPassword.Clear(); // Xóa trống mật khẩu, chỉ điền khi muốn đổi

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    HoTen = txtFullName.Text.Trim(),
                    RoleId = Convert.ToInt32(cbRole.SelectedValue)
                };

                _userBLL.ThemUser(newUser, txtPassword.Text);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUserId <= 0) return;

                User updatedUser = new User
                {
                    Id = _selectedUserId,
                    Username = txtUsername.Text.Trim(),
                    HoTen = txtFullName.Text.Trim(),
                    RoleId = Convert.ToInt32(cbRole.SelectedValue)
                };

                _userBLL.CapNhatUser(updatedUser, txtPassword.Text);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUserId <= 0) return;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _userBLL.XoaUser(_selectedUserId, _currentLoggedInUserId);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}