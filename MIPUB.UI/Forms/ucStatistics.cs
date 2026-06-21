using System;
using System.Windows.Forms;
using MIPUB.BLL;
using MIPUB.Models.Entities;

namespace MIPUB.UI.Forms
{
    public partial class ucStatistics : UserControl
    {
        private SachBLL _sachBLL = new SachBLL();
        private TacGiaBLL _tacGiaBLL = new TacGiaBLL();

        public ucStatistics()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtYear.Text, out int nam))
                {
                    int count = _sachBLL.DemSachTheoNam(nam);
                    lblCountResult.Text = $"Kết quả: Có {count} đầu sách được xuất bản trong năm {nam}.";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                TacGia tacGia = _tacGiaBLL.TimTacGiaNhieuSachNhat();
                if (tacGia != null)
                {
                    // Lấy danh sách sách của tác giả này để hiển thị
                    var dsSach = _sachBLL.LaySachTheoTacGia(tacGia.Id);

                    lblAuthorResult.Text = $"Tác giả: {tacGia.HoTen} (ID: {tacGia.Id})\nTiểu sử: {tacGia.TieuSu}\nSố lượng sách đã xuất bản: {dsSach.Count} cuốn.";

                    // Xóa danh sách cũ
                    lstBooksOfAuthor.Items.Clear();
                    foreach (var s in dsSach)
                    {
                        lstBooksOfAuthor.Items.Add($"- {s.MaSach} | {s.TieuDe} ({s.NamXuatBan})");
                    }
                }
                else
                {
                    lblAuthorResult.Text = "Không tìm thấy dữ liệu tác giả.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}