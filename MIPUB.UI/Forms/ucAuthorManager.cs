using System;
using System.Windows.Forms;
using MIPUB.BLL;
using MIPUB.Models.Entities;

namespace MIPUB.UI.Forms
{
    public partial class ucAuthorManager : UserControl
    {
        private TacGiaBLL _tacGiaBLL = new TacGiaBLL();
        private int _selectedAuthorId = -1;

        public ucAuthorManager()
        {
            InitializeComponent();
        }

        private void ucAuthorManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvAuthors.Rows.Clear();
                var list = _tacGiaBLL.LayTatCaTacGia();
                foreach (var tg in list)
                {
                    dgvAuthors.Rows.Add(tg.Id, tg.HoTen, tg.TieuSu);
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tác giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            _selectedAuthorId = -1;
            txtHoTen.Clear();
            txtTieuSu.Clear();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAuthors.Rows[e.RowIndex];
                _selectedAuthorId = Convert.ToInt32(row.Cells["ColId"].Value);
                txtHoTen.Text = row.Cells["ColHoTen"].Value?.ToString();
                txtTieuSu.Text = row.Cells["ColTieuSu"].Value?.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia newTg = new TacGia { HoTen = txtHoTen.Text.Trim(), TieuSu = txtTieuSu.Text.Trim() };
                _tacGiaBLL.ThemTacGia(newTg);
                MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAuthorId <= 0) return;
                TacGia updatedTg = new TacGia { Id = _selectedAuthorId, HoTen = txtHoTen.Text.Trim(), TieuSu = txtTieuSu.Text.Trim() };
                _tacGiaBLL.CapNhatTacGia(updatedTg);
                MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAuthorId <= 0) return;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _tacGiaBLL.XoaTacGia(_selectedAuthorId);
                    MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
    }
}