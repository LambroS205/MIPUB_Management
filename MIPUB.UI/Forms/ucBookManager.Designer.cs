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
            lblTitle = new Label();
            dgvBooks = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColMaSach = new DataGridViewTextBoxColumn();
            ColTieuDe = new DataGridViewTextBoxColumn();
            ColNam = new DataGridViewTextBoxColumn();
            ColTacGia = new DataGridViewTextBoxColumn();
            ColLoai = new DataGridViewTextBoxColumn();
            ColChiTiet = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            gbAddBook = new GroupBox();
            txtTacGiaId = new TextBox();
            txtNamXB = new TextBox();
            txtTieuDe = new TextBox();
            txtMaSach = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblMaSach = new Label();
            lblTieuDe = new Label();
            lblNamXB = new Label();
            lblTacGiaId = new Label();
            rbSachIn = new RadioButton();
            rbSachDienTu = new RadioButton();
            pnlSachIn = new Panel();
            txtKichThuoc = new TextBox();
            txtSoTrang = new TextBox();
            lblSoTrang = new Label();
            lblKichThuoc = new Label();
            pnlSachDienTu = new Panel();
            lblDungLuong = new Label();
            txtDungLuong = new TextBox();
            lblDinhDang = new Label();
            txtDinhDang = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            gbAddBook.SuspendLayout();
            pnlSachIn.SuspendLayout();
            pnlSachDienTu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 37);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "QUẢN LÝ SÁCH";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { ColId, ColMaSach, ColTieuDe, ColNam, ColTacGia, ColLoai, ColChiTiet });
            dgvBooks.Location = new Point(27, 120);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(780, 250);
            dgvBooks.TabIndex = 3;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // ColId
            // 
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // ColMaSach
            // 
            ColMaSach.FillWeight = 40F;
            ColMaSach.HeaderText = "Mã Sách";
            ColMaSach.MinimumWidth = 6;
            ColMaSach.Name = "ColMaSach";
            ColMaSach.ReadOnly = true;
            // 
            // ColTieuDe
            // 
            ColTieuDe.FillWeight = 80F;
            ColTieuDe.HeaderText = "Tiêu Đề";
            ColTieuDe.MinimumWidth = 6;
            ColTieuDe.Name = "ColTieuDe";
            ColTieuDe.ReadOnly = true;
            // 
            // ColNam
            // 
            ColNam.FillWeight = 40F;
            ColNam.HeaderText = "Năm XB";
            ColNam.MinimumWidth = 6;
            ColNam.Name = "ColNam";
            ColNam.ReadOnly = true;
            // 
            // ColTacGia
            // 
            ColTacGia.FillWeight = 60F;
            ColTacGia.HeaderText = "Tác Giả";
            ColTacGia.MinimumWidth = 6;
            ColTacGia.Name = "ColTacGia";
            ColTacGia.ReadOnly = true;
            // 
            // ColLoai
            // 
            ColLoai.FillWeight = 40F;
            ColLoai.HeaderText = "Loại";
            ColLoai.MinimumWidth = 6;
            ColLoai.Name = "ColLoai";
            ColLoai.ReadOnly = true;
            // 
            // ColChiTiet
            // 
            ColChiTiet.FillWeight = 150F;
            ColChiTiet.HeaderText = "Chi Tiết";
            ColChiTiet.MinimumWidth = 6;
            ColChiTiet.Name = "ColChiTiet";
            ColChiTiet.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(27, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tiêu đề sách để tìm...";
            txtSearch.Size = new Size(300, 30);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 120, 215);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(340, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportExcel.BackColor = Color.ForestGreen;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(590, 68);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(100, 34);
            btnExportExcel.TabIndex = 0;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportPdf.BackColor = Color.Firebrick;
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(700, 68);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(100, 34);
            btnExportPdf.TabIndex = 1;
            btnExportPdf.Text = "Xuất PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // gbAddBook
            // 
            gbAddBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddBook.Controls.Add(txtTacGiaId);
            gbAddBook.Controls.Add(txtNamXB);
            gbAddBook.Controls.Add(txtTieuDe);
            gbAddBook.Controls.Add(txtMaSach);
            gbAddBook.Controls.Add(btnClear);
            gbAddBook.Controls.Add(btnDelete);
            gbAddBook.Controls.Add(btnUpdate);
            gbAddBook.Controls.Add(lblMaSach);
            gbAddBook.Controls.Add(lblTieuDe);
            gbAddBook.Controls.Add(lblNamXB);
            gbAddBook.Controls.Add(lblTacGiaId);
            gbAddBook.Controls.Add(rbSachIn);
            gbAddBook.Controls.Add(rbSachDienTu);
            gbAddBook.Controls.Add(pnlSachIn);
            gbAddBook.Controls.Add(pnlSachDienTu);
            gbAddBook.Controls.Add(btnAdd);
            gbAddBook.Location = new Point(27, 390);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Size = new Size(780, 230);
            gbAddBook.TabIndex = 2;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Thông tin chi tiết";
            // 
            // txtTacGiaId
            // 
            txtTacGiaId.Location = new Point(730, 30);
            txtTacGiaId.Name = "txtTacGiaId";
            txtTacGiaId.Size = new Size(40, 27);
            txtTacGiaId.TabIndex = 10;
            // 
            // txtNamXB
            // 
            txtNamXB.Location = new Point(570, 30);
            txtNamXB.Name = "txtNamXB";
            txtNamXB.Size = new Size(60, 27);
            txtNamXB.TabIndex = 8;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(280, 30);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(200, 27);
            txtTieuDe.TabIndex = 6;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(100, 30);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(100, 27);
            txtMaSach.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(505, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 0;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(370, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(235, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblMaSach
            // 
            lblMaSach.Location = new Point(20, 30);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(74, 23);
            lblMaSach.TabIndex = 3;
            lblMaSach.Text = "Mã sách:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.Location = new Point(220, 30);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(80, 23);
            lblTieuDe.TabIndex = 5;
            lblTieuDe.Text = "Tiêu đề:";
            // 
            // lblNamXB
            // 
            lblNamXB.Location = new Point(500, 30);
            lblNamXB.Name = "lblNamXB";
            lblNamXB.Size = new Size(100, 23);
            lblNamXB.TabIndex = 7;
            lblNamXB.Text = "Năm XB:";
            // 
            // lblTacGiaId
            // 
            lblTacGiaId.Location = new Point(650, 30);
            lblTacGiaId.Name = "lblTacGiaId";
            lblTacGiaId.Size = new Size(100, 23);
            lblTacGiaId.TabIndex = 9;
            lblTacGiaId.Text = "ID Tác Giả:";
            // 
            // rbSachIn
            // 
            rbSachIn.Location = new Point(100, 80);
            rbSachIn.Name = "rbSachIn";
            rbSachIn.Size = new Size(86, 24);
            rbSachIn.TabIndex = 11;
            rbSachIn.Text = "Sách In";
            rbSachIn.CheckedChanged += rbSachIn_CheckedChanged;
            // 
            // rbSachDienTu
            // 
            rbSachDienTu.Location = new Point(200, 80);
            rbSachDienTu.Name = "rbSachDienTu";
            rbSachDienTu.Size = new Size(104, 24);
            rbSachDienTu.TabIndex = 12;
            rbSachDienTu.Text = "Sách Điện Tử";
            // 
            // pnlSachIn
            // 
            pnlSachIn.Controls.Add(txtKichThuoc);
            pnlSachIn.Controls.Add(txtSoTrang);
            pnlSachIn.Controls.Add(lblSoTrang);
            pnlSachIn.Controls.Add(lblKichThuoc);
            pnlSachIn.Location = new Point(100, 110);
            pnlSachIn.Name = "pnlSachIn";
            pnlSachIn.Size = new Size(400, 40);
            pnlSachIn.TabIndex = 13;
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.Location = new Point(235, 5);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.Size = new Size(100, 27);
            txtKichThuoc.TabIndex = 3;
            // 
            // txtSoTrang
            // 
            txtSoTrang.Location = new Point(70, 5);
            txtSoTrang.Name = "txtSoTrang";
            txtSoTrang.Size = new Size(60, 27);
            txtSoTrang.TabIndex = 1;
            // 
            // lblSoTrang
            // 
            lblSoTrang.Location = new Point(0, 5);
            lblSoTrang.Name = "lblSoTrang";
            lblSoTrang.Size = new Size(100, 23);
            lblSoTrang.TabIndex = 0;
            lblSoTrang.Text = "Số trang:";
            // 
            // lblKichThuoc
            // 
            lblKichThuoc.Location = new Point(150, 5);
            lblKichThuoc.Name = "lblKichThuoc";
            lblKichThuoc.Size = new Size(100, 23);
            lblKichThuoc.TabIndex = 2;
            lblKichThuoc.Text = "Kích thước:";
            // 
            // pnlSachDienTu
            // 
            pnlSachDienTu.Controls.Add(lblDungLuong);
            pnlSachDienTu.Controls.Add(txtDungLuong);
            pnlSachDienTu.Controls.Add(lblDinhDang);
            pnlSachDienTu.Controls.Add(txtDinhDang);
            pnlSachDienTu.Location = new Point(100, 110);
            pnlSachDienTu.Name = "pnlSachDienTu";
            pnlSachDienTu.Size = new Size(400, 40);
            pnlSachDienTu.TabIndex = 14;
            pnlSachDienTu.Visible = false;
            // 
            // lblDungLuong
            // 
            lblDungLuong.Location = new Point(0, 5);
            lblDungLuong.Name = "lblDungLuong";
            lblDungLuong.Size = new Size(100, 23);
            lblDungLuong.TabIndex = 0;
            lblDungLuong.Text = "Dung lượng (MB):";
            // 
            // txtDungLuong
            // 
            txtDungLuong.Location = new Point(120, 5);
            txtDungLuong.Name = "txtDungLuong";
            txtDungLuong.Size = new Size(60, 27);
            txtDungLuong.TabIndex = 1;
            // 
            // lblDinhDang
            // 
            lblDinhDang.Location = new Point(200, 5);
            lblDinhDang.Name = "lblDinhDang";
            lblDinhDang.Size = new Size(100, 23);
            lblDinhDang.TabIndex = 2;
            lblDinhDang.Text = "Định dạng:";
            // 
            // txtDinhDang
            // 
            txtDinhDang.Location = new Point(285, 5);
            txtDinhDang.Name = "txtDinhDang";
            txtDinhDang.Size = new Size(100, 27);
            txtDinhDang.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(100, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm Sách";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ucBookManager
            // 
            BackColor = Color.White;
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportPdf);
            Controls.Add(gbAddBook);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            Name = "ucBookManager";
            Size = new Size(832, 653);
            Load += ucBookManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            pnlSachIn.ResumeLayout(false);
            pnlSachIn.PerformLayout();
            pnlSachDienTu.ResumeLayout(false);
            pnlSachDienTu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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