using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MIPUB.BLL;
using MIPUB.BLL.Utils;
using MIPUB.Models.Entities;

namespace MIPUB.UI.Forms
{
    public partial class ucBookManager : UserControl
    {
        private SachBLL _sachBLL = new SachBLL();
        private ExportHelper _exportHelper = new ExportHelper();
        private int _selectedBookId = -1;

        // Biến lưu trữ danh sách đang hiển thị hiện tại trên Grid (dùng để xuất file)
        private List<Sach> _currentData = new List<Sach>();

        public ucBookManager()
        {
            InitializeComponent();
        }

        private void ucBookManager_Load(object sender, EventArgs e)
        {
            LoadData();
            rbSachIn.Checked = true;
        }

        private void LoadData(string tuKhoa = "")
        {
            try
            {
                dgvBooks.Rows.Clear();
                _currentData = string.IsNullOrEmpty(tuKhoa)
                                    ? _sachBLL.LayTatCaSach()
                                    : _sachBLL.TimKiemSachtheoTieuDe(tuKhoa);

                foreach (var sach in _currentData)
                {
                    dgvBooks.Rows.Add(sach.Id, sach.MaSach, sach.TieuDe, sach.NamXuatBan, sach.TacGia?.HoTen ?? sach.TacGiaId.ToString(), sach.LoaiSach, sach.HienThiThongTin());
                }
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            _selectedBookId = -1;
            txtMaSach.Enabled = true;
            txtMaSach.Clear();
            txtTieuDe.Clear();
            txtNamXB.Clear();
            txtTacGiaId.Clear();
            txtSoTrang.Clear();
            txtKichThuoc.Clear();
            txtDungLuong.Clear();
            txtDinhDang.Clear();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                _selectedBookId = Convert.ToInt32(row.Cells["ColId"].Value);
                string maSach = row.Cells["ColMaSach"].Value.ToString();

                Sach sachDetail = _sachBLL.TimKiemTheoMa(maSach);
                if (sachDetail != null)
                {
                    txtMaSach.Text = sachDetail.MaSach;
                    txtMaSach.Enabled = false;
                    txtTieuDe.Text = sachDetail.TieuDe;
                    txtNamXB.Text = sachDetail.NamXuatBan.ToString();
                    txtTacGiaId.Text = sachDetail.TacGiaId.ToString();

                    if (sachDetail is SachIn sIn)
                    {
                        rbSachIn.Checked = true;
                        txtSoTrang.Text = sIn.SoTrang.ToString();
                        txtKichThuoc.Text = sIn.KichThuoc;
                    }
                    else if (sachDetail is SachDienTu sEbook)
                    {
                        rbSachDienTu.Checked = true;
                        txtDungLuong.Text = sEbook.DungLuongMB.ToString();
                        txtDinhDang.Text = sEbook.DinhDang;
                    }

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private Sach GetSachFromForm()
        {
            Sach sach;
            if (rbSachIn.Checked)
            {
                sach = new SachIn
                {
                    SoTrang = string.IsNullOrWhiteSpace(txtSoTrang.Text) ? 0 : int.Parse(txtSoTrang.Text),
                    KichThuoc = txtKichThuoc.Text
                };
            }
            else
            {
                sach = new SachDienTu
                {
                    DungLuongMB = string.IsNullOrWhiteSpace(txtDungLuong.Text) ? 0 : double.Parse(txtDungLuong.Text),
                    DinhDang = txtDinhDang.Text
                };
            }
            sach.MaSach = txtMaSach.Text.Trim();
            sach.TieuDe = txtTieuDe.Text.Trim();
            sach.NamXuatBan = int.Parse(txtNamXB.Text);
            sach.TacGiaId = int.Parse(txtTacGiaId.Text);

            if (_selectedBookId > 0) sach.Id = _selectedBookId;
            return sach;
        }

        // --- CÁC NÚT CRUD ---
        private void btnAdd_Click(object sender, EventArgs e)
        { /* Giữ nguyên như cũ, gọi GetSachFromForm() và _sachBLL.ThemSach */
            try { _sachBLL.ThemSach(GetSachFromForm()); MessageBox.Show("Thêm sách thành công!"); LoadData(); }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try { if (_selectedBookId <= 0) return; _sachBLL.CapNhatSach(GetSachFromForm()); MessageBox.Show("Cập nhật thành công!"); LoadData(); }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { if (_selectedBookId <= 0) return; if (MessageBox.Show("Xóa sách này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes) { _sachBLL.XoaSach(_selectedBookId); MessageBox.Show("Đã xóa!"); LoadData(); } }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
        private void btnSearch_Click(object sender, EventArgs e) => LoadData(txtSearch.Text.Trim());
        private void rbSachIn_CheckedChanged(object sender, EventArgs e) { pnlSachIn.Visible = rbSachIn.Checked; pnlSachDienTu.Visible = rbSachDienTu.Checked; }

        // --- SỰ KIỆN XUẤT BÁO CÁO ---
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (_currentData == null || _currentData.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "BaoCaoSach.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _exportHelper.ExportToExcel(_currentData, sfd.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (_currentData == null || _currentData.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Document|*.pdf", FileName = "BaoCaoSach.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _exportHelper.ExportToPdf(_currentData, sfd.FileName);
                        MessageBox.Show("Xuất file PDF thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}