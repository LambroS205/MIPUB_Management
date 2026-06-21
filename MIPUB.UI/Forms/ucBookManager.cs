using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MIPUB.BLL;
using MIPUB.Models.Entities;

namespace MIPUB.UI.Forms
{
    public partial class ucBookManager : UserControl
    {
        private SachBLL _sachBLL = new SachBLL();

        public ucBookManager()
        {
            InitializeComponent();
        }

        private void ucBookManager_Load(object sender, EventArgs e)
        {
            LoadData();
            rbSachIn.Checked = true; // Mặc định chọn sách in
        }

        private void LoadData(string tuKhoa = "")
        {
            try
            {
                dgvBooks.Rows.Clear();
                List<Sach> list = string.IsNullOrEmpty(tuKhoa)
                                    ? _sachBLL.LayTatCaSach()
                                    : _sachBLL.TimKiemSachtheoTieuDe(tuKhoa);

                foreach (var sach in list)
                {
                    // TÍNH ĐA HÌNH Ở ĐÂY: Hàm HienThiThongTin() sẽ tự động gọi đúng class con (SachIn hoặc SachDienTu)
                    dgvBooks.Rows.Add(sach.MaSach, sach.TieuDe, sach.NamXuatBan, sach.TacGia?.HoTen ?? sach.TacGiaId.ToString(), sach.LoaiSach, sach.HienThiThongTin());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void rbSachIn_CheckedChanged(object sender, EventArgs e)
        {
            pnlSachIn.Visible = rbSachIn.Checked;
            pnlSachDienTu.Visible = rbSachDienTu.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Sach newSach;

                // TÍNH KẾ THỪA VÀ ĐA HÌNH TRONG KHỞI TẠO
                if (rbSachIn.Checked)
                {
                    newSach = new SachIn
                    {
                        SoTrang = string.IsNullOrWhiteSpace(txtSoTrang.Text) ? 0 : int.Parse(txtSoTrang.Text),
                        KichThuoc = txtKichThuoc.Text
                    };
                }
                else
                {
                    newSach = new SachDienTu
                    {
                        DungLuongMB = string.IsNullOrWhiteSpace(txtDungLuong.Text) ? 0 : double.Parse(txtDungLuong.Text),
                        DinhDang = txtDinhDang.Text
                    };
                }

                // Gán các thuộc tính chung (Tính đóng gói sẽ validate ở Models)
                newSach.MaSach = txtMaSach.Text.Trim();
                newSach.TieuDe = txtTieuDe.Text.Trim();
                newSach.NamXuatBan = int.Parse(txtNamXB.Text);
                newSach.TacGiaId = int.Parse(txtTacGiaId.Text);

                _sachBLL.ThemSach(newSach);
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Reload grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sách: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}