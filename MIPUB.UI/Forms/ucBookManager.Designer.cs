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
            this.ColMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbAddBook.SuspendLayout();
            this.pnlSachIn.SuspendLayout();
            this.pnlSachDienTu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SÁCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(27, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Nhập tiêu đề sách để tìm...";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(340, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaSach,
            this.ColTieuDe,
            this.ColNam,
            this.ColTacGia,
            this.ColLoai,
            this.ColChiTiet});
            this.dgvBooks.Location = new System.Drawing.Point(27, 120);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 29;
            this.dgvBooks.Size = new System.Drawing.Size(780, 280);
            this.dgvBooks.TabIndex = 3;
            // 
            // ColMaSach
            // 
            this.ColMaSach.HeaderText = "Mã Sách";
            this.ColMaSach.Name = "ColMaSach";
            this.ColMaSach.ReadOnly = true;
            this.ColMaSach.FillWeight = 40F;
            // 
            // ColTieuDe
            // 
            this.ColTieuDe.HeaderText = "Tiêu Đề";
            this.ColTieuDe.Name = "ColTieuDe";
            this.ColTieuDe.ReadOnly = true;
            this.ColTieuDe.FillWeight = 80F;
            // 
            // ColNam
            // 
            this.ColNam.HeaderText = "Năm XB";
            this.ColNam.Name = "ColNam";
            this.ColNam.ReadOnly = true;
            this.ColNam.FillWeight = 40F;
            // 
            // ColTacGia
            // 
            this.ColTacGia.HeaderText = "Tác Giả";
            this.ColTacGia.Name = "ColTacGia";
            this.ColTacGia.ReadOnly = true;
            this.ColTacGia.FillWeight = 60F;
            // 
            // ColLoai
            // 
            this.ColLoai.HeaderText = "Loại";
            this.ColLoai.Name = "ColLoai";
            this.ColLoai.ReadOnly = true;
            this.ColLoai.FillWeight = 40F;
            // 
            // ColChiTiet
            // 
            this.ColChiTiet.HeaderText = "Chi Tiết (Đa Hình)";
            this.ColChiTiet.Name = "ColChiTiet";
            this.ColChiTiet.ReadOnly = true;
            this.ColChiTiet.FillWeight = 150F;
            // 
            // gbAddBook
            // 
            this.gbAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbAddBook.Location = new System.Drawing.Point(27, 420);
            this.gbAddBook.Name = "gbAddBook";
            this.gbAddBook.Size = new System.Drawing.Size(780, 200);
            this.gbAddBook.TabIndex = 4;
            this.gbAddBook.TabStop = false;
            this.gbAddBook.Text = "Thêm sách mới";
            // 
            // Textboxes & Labels chung
            // 
            this.lblMaSach.Location = new System.Drawing.Point(20, 30);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(80, 25);
            this.lblMaSach.Text = "Mã sách:";

            this.txtMaSach.Location = new System.Drawing.Point(100, 30);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 27);

            this.lblTieuDe.Location = new System.Drawing.Point(220, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(60, 25);
            this.lblTieuDe.Text = "Tiêu đề:";

            this.txtTieuDe.Location = new System.Drawing.Point(280, 30);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(200, 27);

            this.lblNamXB.Location = new System.Drawing.Point(500, 30);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Size = new System.Drawing.Size(70, 25);
            this.lblNamXB.Text = "Năm XB:";

            this.txtNamXB.Location = new System.Drawing.Point(570, 30);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(60, 27);

            this.lblTacGiaId.Location = new System.Drawing.Point(650, 30);
            this.lblTacGiaId.Name = "lblTacGiaId";
            this.lblTacGiaId.Size = new System.Drawing.Size(80, 25);
            this.lblTacGiaId.Text = "ID Tác Giả:";

            this.txtTacGiaId.Location = new System.Drawing.Point(730, 30);
            this.txtTacGiaId.Name = "txtTacGiaId";
            this.txtTacGiaId.Size = new System.Drawing.Size(40, 27);

            // Radio Buttons
            // 
            this.rbSachIn.AutoSize = true;
            this.rbSachIn.Location = new System.Drawing.Point(100, 80);
            this.rbSachIn.Name = "rbSachIn";
            this.rbSachIn.Size = new System.Drawing.Size(78, 24);
            this.rbSachIn.Text = "Sách In";
            this.rbSachIn.UseVisualStyleBackColor = true;
            this.rbSachIn.CheckedChanged += new System.EventHandler(this.rbSachIn_CheckedChanged);

            this.rbSachDienTu.AutoSize = true;
            this.rbSachDienTu.Location = new System.Drawing.Point(200, 80);
            this.rbSachDienTu.Name = "rbSachDienTu";
            this.rbSachDienTu.Size = new System.Drawing.Size(117, 24);
            this.rbSachDienTu.Text = "Sách Điện Tử";
            this.rbSachDienTu.UseVisualStyleBackColor = true;
            // 
            // pnlSachIn
            // 
            this.pnlSachIn.Controls.Add(this.lblSoTrang);
            this.pnlSachIn.Controls.Add(this.txtSoTrang);
            this.pnlSachIn.Controls.Add(this.lblKichThuoc);
            this.pnlSachIn.Controls.Add(this.txtKichThuoc);
            this.pnlSachIn.Location = new System.Drawing.Point(100, 110);
            this.pnlSachIn.Name = "pnlSachIn";
            this.pnlSachIn.Size = new System.Drawing.Size(400, 40);
            // 
            // pnlSachIn Controls
            // 
            this.lblSoTrang.Location = new System.Drawing.Point(0, 5);
            this.lblSoTrang.Name = "lblSoTrang";
            this.lblSoTrang.Size = new System.Drawing.Size(70, 25);
            this.lblSoTrang.Text = "Số trang:";

            this.txtSoTrang.Location = new System.Drawing.Point(70, 5);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(60, 27);

            this.lblKichThuoc.Location = new System.Drawing.Point(150, 5);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(85, 25);
            this.lblKichThuoc.Text = "Kích thước:";

            this.txtKichThuoc.Location = new System.Drawing.Point(235, 5);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(100, 27);
            // 
            // pnlSachDienTu
            // 
            this.pnlSachDienTu.Controls.Add(this.lblDungLuong);
            this.pnlSachDienTu.Controls.Add(this.txtDungLuong);
            this.pnlSachDienTu.Controls.Add(this.lblDinhDang);
            this.pnlSachDienTu.Controls.Add(this.txtDinhDang);
            this.pnlSachDienTu.Location = new System.Drawing.Point(100, 110);
            this.pnlSachDienTu.Name = "pnlSachDienTu";
            this.pnlSachDienTu.Size = new System.Drawing.Size(400, 40);
            this.pnlSachDienTu.Visible = false;
            // 
            // pnlSachDienTu Controls
            // 
            this.lblDungLuong.Location = new System.Drawing.Point(0, 5);
            this.lblDungLuong.Name = "lblDungLuong";
            this.lblDungLuong.Size = new System.Drawing.Size(120, 25);
            this.lblDungLuong.Text = "Dung lượng (MB):";

            this.txtDungLuong.Location = new System.Drawing.Point(120, 5);
            this.txtDungLuong.Name = "txtDungLuong";
            this.txtDungLuong.Size = new System.Drawing.Size(60, 27);

            this.lblDinhDang.Location = new System.Drawing.Point(200, 5);
            this.lblDinhDang.Name = "lblDinhDang";
            this.lblDinhDang.Size = new System.Drawing.Size(85, 25);
            this.lblDinhDang.Text = "Định dạng:";

            this.txtDinhDang.Location = new System.Drawing.Point(285, 5);
            this.txtDinhDang.Name = "txtDinhDang";
            this.txtDinhDang.Size = new System.Drawing.Size(100, 27);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(100, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Thêm Sách";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbAddBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucBookManager";
            this.Size = new System.Drawing.Size(832, 653);
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

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
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

        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblTacGiaId;
        private System.Windows.Forms.Label lblSoTrang;
        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.Label lblDungLuong;
        private System.Windows.Forms.Label lblDinhDang;

        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChiTiet;
    }
}