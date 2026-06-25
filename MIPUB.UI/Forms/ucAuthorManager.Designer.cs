namespace MIPUB.UI.Forms
{
    partial class ucAuthorManager
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
            dgvAuthors = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColHoTen = new DataGridViewTextBoxColumn();
            ColTieuSu = new DataGridViewTextBoxColumn();
            gbAddAuthor = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblTieuSu = new Label();
            txtTieuSu = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            gbAddAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // dgvAuthors
            // 
            dgvAuthors.AllowUserToAddRows = false;
            dgvAuthors.AllowUserToDeleteRows = false;
            dgvAuthors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuthors.BackgroundColor = Color.White;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Columns.AddRange(new DataGridViewColumn[] { ColId, ColHoTen, ColTieuSu });
            dgvAuthors.Location = new Point(27, 80);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.ReadOnly = true;
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.Size = new Size(780, 340);
            dgvAuthors.TabIndex = 1;
            dgvAuthors.CellClick += dgvAuthors_CellClick;
            // 
            // ColId
            // 
            ColId.FillWeight = 20F;
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColHoTen
            // 
            ColHoTen.FillWeight = 40F;
            ColHoTen.HeaderText = "Họ Tên Tác Giả";
            ColHoTen.MinimumWidth = 6;
            ColHoTen.Name = "ColHoTen";
            ColHoTen.ReadOnly = true;
            // 
            // ColTieuSu
            // 
            ColTieuSu.HeaderText = "Tiểu Sử";
            ColTieuSu.MinimumWidth = 6;
            ColTieuSu.Name = "ColTieuSu";
            ColTieuSu.ReadOnly = true;
            // 
            // gbAddAuthor
            // 
            gbAddAuthor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddAuthor.Controls.Add(txtHoTen);
            gbAddAuthor.Controls.Add(txtTieuSu);
            gbAddAuthor.Controls.Add(btnClear);
            gbAddAuthor.Controls.Add(btnDelete);
            gbAddAuthor.Controls.Add(btnUpdate);
            gbAddAuthor.Controls.Add(btnAdd);
            gbAddAuthor.Controls.Add(lblTieuSu);
            gbAddAuthor.Controls.Add(lblHoTen);
            gbAddAuthor.Location = new Point(27, 440);
            gbAddAuthor.Name = "gbAddAuthor";
            gbAddAuthor.Size = new Size(780, 180);
            gbAddAuthor.TabIndex = 0;
            gbAddAuthor.TabStop = false;
            gbAddAuthor.Text = "Thông tin chi tiết";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(460, 130);
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
            btnDelete.Location = new Point(340, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(220, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(100, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTieuSu
            // 
            lblTieuSu.Location = new Point(330, 40);
            lblTieuSu.Name = "lblTieuSu";
            lblTieuSu.Size = new Size(100, 23);
            lblTieuSu.TabIndex = 4;
            lblTieuSu.Text = "Tiểu sử:";
            // 
            // txtTieuSu
            // 
            txtTieuSu.Location = new Point(400, 37);
            txtTieuSu.Multiline = true;
            txtTieuSu.Name = "txtTieuSu";
            txtTieuSu.Size = new Size(350, 70);
            txtTieuSu.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(30, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(100, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 27);
            txtHoTen.TabIndex = 7;
            // 
            // ucAuthorManager
            // 
            BackColor = Color.White;
            Controls.Add(gbAddAuthor);
            Controls.Add(dgvAuthors);
            Controls.Add(lblTitle);
            Name = "ucAuthorManager";
            Size = new Size(832, 653);
            Load += ucAuthorManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            gbAddAuthor.ResumeLayout(false);
            gbAddAuthor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.GroupBox gbAddAuthor;
        private System.Windows.Forms.Label lblHoTen, lblTieuSu;
        private System.Windows.Forms.TextBox txtHoTen, txtTieuSu;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId, ColHoTen, ColTieuSu;
    }
}