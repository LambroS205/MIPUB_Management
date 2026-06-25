namespace MIPUB.UI.Forms
{
    partial class ucBookManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            // CÁC NÚT XUẤT BÁO CÁO
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();

            this.gbAddBook = new System.Windows.Forms.GroupBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.lblTacGiaId = new System.Windows.Forms.Label();
            this.txtTacGiaId = new System.Windows.Forms.TextBox();
            this.rbSachIn = new System.Windows.Forms.RadioButton();
            this.rbSachDienTu = new System.Windows.Forms.RadioButton();
            this.pnlSachIn = new System.Windows.Forms.Panel();
            this.lblSoTrang = new System.Windows.Forms.Label();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.pnlSachDienTu = new System.Windows.Forms.Panel();
            this.lblDungLuong = new System.Windows.Forms.Label();
            this.txtDungLuong = new System.Windows.Forms.TextBox();
            this.lblDinhDang = new System.Windows.Forms.Label();
            this.txtDinhDang = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbAddBook.SuspendLayout();
            this.pnlSachIn.SuspendLayout();
            this.pnlSachDienTu.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 37);
            this.lblTitle.Text = "QUẢN LÝ SÁCH";

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(27, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Nhập tiêu đề sách để tìm...";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(340, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnExportExcel
            this.btnExportExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(590, 68);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 34);
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);

            // btnExportPdf
            this.btnExportPdf.BackColor = System.Drawing.Color.Firebrick;
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.Location = new System.Drawing.Point(700, 68);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(100, 34);
            this.btnExportPdf.Text = "Xuất PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);

            // dgvBooks
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId, this.ColMaSach, this.ColTieuDe, this.ColNam, this.ColTacGia, this.ColLoai, this.ColChiTiet});
            this.dgvBooks.Location = new System.Drawing.Point(27, 120);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(780, 250);
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);

            // ... (Phần cột DataGridView giữ nguyên như file trước) ...
            this.ColId.Name = "ColId"; this.ColId.Visible = false;
            this.ColMaSach.HeaderText = "Mã Sách"; this.ColMaSach.Name = "ColMaSach"; this.ColMaSach.FillWeight = 40F;
            this.ColTieuDe.HeaderText = "Tiêu Đề"; this.ColTieuDe.Name = "ColTieuDe"; this.ColTieuDe.FillWeight = 80F;
            this.ColNam.HeaderText = "Năm XB"; this.ColNam.Name = "ColNam"; this.ColNam.FillWeight = 40F;
            this.ColTacGia.HeaderText = "Tác Giả"; this.ColTacGia.Name = "ColTacGia"; this.ColTacGia.FillWeight = 60F;
            this.ColLoai.HeaderText = "Loại"; this.ColLoai.Name = "ColLoai"; this.ColLoai.FillWeight = 40F;
            this.ColChiTiet.HeaderText = "Chi Tiết"; this.ColChiTiet.Name = "ColChiTiet"; this.ColChiTiet.FillWeight = 150F;

            // gbAddBook & Controls Layout
            this.gbAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddBook.Controls.Add(this.btnClear);
            this.gbAddBook.Controls.Add(this.btnDelete);
            this.gbAddBook.Controls.Add(this.btnUpdate);
            this.gbAddBook.Controls.Add(this.lblMaSach);
            this.gbAddBook.Controls.Add(this.txtMaSach);
            this.gbAddBook.Controls.Add(this.lblTieuDe);
            this.gbAddBook.Controls.Add(this.txtTieuDe);
            this.gbAddBook.Controls.Add(this.lblNamXB);
            this.gbAddBook.Controls.Add(this.txtNamXB);
            this.gbAddBook.Controls.Add(this.lblTacGiaId);
            this.gbAddBook.Controls.Add(this.txtTacGiaId);
            this.gbAddBook.Controls.Add(this.rbSachIn);
            this.gbAddBook.Controls.Add(this.rbSachDienTu);
            this.gbAddBook.Controls.Add(this.pnlSachIn);
            this.gbAddBook.Controls.Add(this.pnlSachDienTu);
            this.gbAddBook.Controls.Add(this.btnAdd);
            this.gbAddBook.Location = new System.Drawing.Point(27, 390);
            this.gbAddBook.Name = "gbAddBook";
            this.gbAddBook.Size = new System.Drawing.Size(780, 230);
            this.gbAddBook.Text = "Thông tin chi tiết";

            // ... (Khai báo các Textbox, Label giống y hệt file cũ, tôi xin rút gọn phần setup vị trí để bạn copy file cũ nếu cần, hoặc dùng lại phần này) ...
            this.lblMaSach.Location = new System.Drawing.Point(20, 30); this.lblMaSach.Text = "Mã sách:";
            this.txtMaSach.Location = new System.Drawing.Point(100, 30); this.txtMaSach.Size = new System.Drawing.Size(100, 27);
            this.lblTieuDe.Location = new System.Drawing.Point(220, 30); this.lblTieuDe.Text = "Tiêu đề:";
            this.txtTieuDe.Location = new System.Drawing.Point(280, 30); this.txtTieuDe.Size = new System.Drawing.Size(200, 27);
            this.lblNamXB.Location = new System.Drawing.Point(500, 30); this.lblNamXB.Text = "Năm XB:";
            this.txtNamXB.Location = new System.Drawing.Point(570, 30); this.txtNamXB.Size = new System.Drawing.Size(60, 27);
            this.lblTacGiaId.Location = new System.Drawing.Point(650, 30); this.lblTacGiaId.Text = "ID Tác Giả:";
            this.txtTacGiaId.Location = new System.Drawing.Point(730, 30); this.txtTacGiaId.Size = new System.Drawing.Size(40, 27);

            this.rbSachIn.Location = new System.Drawing.Point(100, 80); this.rbSachIn.Text = "Sách In"; this.rbSachIn.CheckedChanged += new System.EventHandler(this.rbSachIn_CheckedChanged);
            this.rbSachDienTu.Location = new System.Drawing.Point(200, 80); this.rbSachDienTu.Text = "Sách Điện Tử";

            this.pnlSachIn.Location = new System.Drawing.Point(100, 110); this.pnlSachIn.Size = new System.Drawing.Size(400, 40);
            this.pnlSachIn.Controls.Add(this.lblSoTrang); this.pnlSachIn.Controls.Add(this.txtSoTrang); this.pnlSachIn.Controls.Add(this.lblKichThuoc); this.pnlSachIn.Controls.Add(this.txtKichThuoc);
            this.lblSoTrang.Location = new System.Drawing.Point(0, 5); this.lblSoTrang.Text = "Số trang:";
            this.txtSoTrang.Location = new System.Drawing.Point(70, 5); this.txtSoTrang.Size = new System.Drawing.Size(60, 27);
            this.lblKichThuoc.Location = new System.Drawing.Point(150, 5); this.lblKichThuoc.Text = "Kích thước:";
            this.txtKichThuoc.Location = new System.Drawing.Point(235, 5); this.txtKichThuoc.Size = new System.Drawing.Size(100, 27);

            this.pnlSachDienTu.Location = new System.Drawing.Point(100, 110); this.pnlSachDienTu.Size = new System.Drawing.Size(400, 40); this.pnlSachDienTu.Visible = false;
            this.pnlSachDienTu.Controls.Add(this.lblDungLuong); this.pnlSachDienTu.Controls.Add(this.txtDungLuong); this.pnlSachDienTu.Controls.Add(this.lblDinhDang); this.pnlSachDienTu.Controls.Add(this.txtDinhDang);
            this.lblDungLuong.Location = new System.Drawing.Point(0, 5); this.lblDungLuong.Text = "Dung lượng (MB):";
            this.txtDungLuong.Location = new System.Drawing.Point(120, 5); this.txtDungLuong.Size = new System.Drawing.Size(60, 27);
            this.lblDinhDang.Location = new System.Drawing.Point(200, 5); this.lblDinhDang.Text = "Định dạng:";
            this.txtDinhDang.Location = new System.Drawing.Point(285, 5); this.txtDinhDang.Size = new System.Drawing.Size(100, 27);

            this.btnAdd.Location = new System.Drawing.Point(100, 170); this.btnAdd.Size = new System.Drawing.Size(120, 35); this.btnAdd.Text = "Thêm Sách"; this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen; this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Location = new System.Drawing.Point(235, 170); this.btnUpdate.Size = new System.Drawing.Size(120, 35); this.btnUpdate.Text = "Cập Nhật"; this.btnUpdate.BackColor = System.Drawing.Color.Orange; this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Location = new System.Drawing.Point(370, 170); this.btnDelete.Size = new System.Drawing.Size(120, 35); this.btnDelete.Text = "Xóa"; this.btnDelete.BackColor = System.Drawing.Color.Crimson; this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Location = new System.Drawing.Point(505, 170); this.btnClear.Size = new System.Drawing.Size(100, 35); this.btnClear.Text = "Làm mới"; this.btnClear.BackColor = System.Drawing.Color.Gray; this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ucBookManager
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.gbAddBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucBookManager";
            this.Size = new System.Drawing.Size(832, 653);
            this.BackColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.ucBookManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbAddBook.ResumeLayout(false);
            this.gbAddBook.PerformLayout();
            this.pnlSachIn.ResumeLayout(false);
            this.pnlSachIn.PerformLayout();
            this.pnlSachDienTu.ResumeLayout(false);
            this.pnlSachDienTu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ... (Khai báo biến y hệt file cũ) ...
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        // BIẾN MỚI CHO EXPORT
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPdf;

        private System.Windows.Forms.GroupBox gbAddBook;
        private System.Windows.Forms.RadioButton rbSachIn;
        private System.Windows.Forms.RadioButton rbSachDienTu;
        private System.Windows.Forms.Panel pnlSachIn;
        private System.Windows.Forms.Panel pnlSachDienTu;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTacGiaId;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.TextBox txtDungLuong;
        private System.Windows.Forms.TextBox txtDinhDang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMaSach, lblTieuDe, lblNamXB, lblTacGiaId, lblSoTrang, lblKichThuoc, lblDungLuong, lblDinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId, ColMaSach, ColTieuDe, ColNam, ColTacGia, ColLoai, ColChiTiet;
    }
}