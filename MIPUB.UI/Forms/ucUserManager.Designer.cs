namespace MIPUB.UI.Forms
{
    partial class ucUserManager
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbAddUser.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";

            // dgvUsers
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId, this.ColUsername, this.ColFullName, this.ColRoleName, this.ColRoleId});
            this.dgvUsers.Location = new System.Drawing.Point(27, 80);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(780, 340);
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);

            // Columns
            this.ColId.Name = "ColId"; this.ColId.Visible = false;
            this.ColUsername.HeaderText = "Tên đăng nhập"; this.ColUsername.Name = "ColUsername";
            this.ColFullName.HeaderText = "Họ và Tên"; this.ColFullName.Name = "ColFullName";
            this.ColRoleName.HeaderText = "Vai trò (Role)"; this.ColRoleName.Name = "ColRoleName";
            this.ColRoleId.Name = "ColRoleId"; this.ColRoleId.Visible = false;

            // gbAddUser
            this.gbAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddUser.Controls.Add(this.btnClear);
            this.gbAddUser.Controls.Add(this.btnDelete);
            this.gbAddUser.Controls.Add(this.btnUpdate);
            this.gbAddUser.Controls.Add(this.btnAdd);
            this.gbAddUser.Controls.Add(this.lblRole);
            this.gbAddUser.Controls.Add(this.cbRole);
            this.gbAddUser.Controls.Add(this.lblFullName);
            this.gbAddUser.Controls.Add(this.txtFullName);
            this.gbAddUser.Controls.Add(this.lblPassword);
            this.gbAddUser.Controls.Add(this.txtPassword);
            this.gbAddUser.Controls.Add(this.lblUsername);
            this.gbAddUser.Controls.Add(this.txtUsername);
            this.gbAddUser.Location = new System.Drawing.Point(27, 440);
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.Size = new System.Drawing.Size(780, 180);
            this.gbAddUser.Text = "Thông tin chi tiết";

            // Inputs layout
            this.lblUsername.Location = new System.Drawing.Point(30, 40); this.lblUsername.Text = "Username:";
            this.txtUsername.Location = new System.Drawing.Point(120, 37); this.txtUsername.Size = new System.Drawing.Size(200, 27);

            this.lblPassword.Location = new System.Drawing.Point(380, 40); this.lblPassword.Text = "Mật khẩu:";
            this.txtPassword.Location = new System.Drawing.Point(460, 37); this.txtPassword.Size = new System.Drawing.Size(200, 27); this.txtPassword.PasswordChar = '●';

            this.lblFullName.Location = new System.Drawing.Point(30, 80); this.lblFullName.Text = "Họ tên:";
            this.txtFullName.Location = new System.Drawing.Point(120, 77); this.txtFullName.Size = new System.Drawing.Size(200, 27);

            this.lblRole.Location = new System.Drawing.Point(380, 80); this.lblRole.Text = "Vai trò:";
            this.cbRole.Location = new System.Drawing.Point(460, 77); this.cbRole.Size = new System.Drawing.Size(200, 28); this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(120, 130); this.btnAdd.Size = new System.Drawing.Size(100, 35); this.btnAdd.Text = "Thêm"; this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen; this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Location = new System.Drawing.Point(240, 130); this.btnUpdate.Size = new System.Drawing.Size(100, 35); this.btnUpdate.Text = "Cập nhật"; this.btnUpdate.BackColor = System.Drawing.Color.Orange; this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Location = new System.Drawing.Point(360, 130); this.btnDelete.Size = new System.Drawing.Size(100, 35); this.btnDelete.Text = "Xóa"; this.btnDelete.BackColor = System.Drawing.Color.Crimson; this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Location = new System.Drawing.Point(480, 130); this.btnClear.Size = new System.Drawing.Size(100, 35); this.btnClear.Text = "Làm mới"; this.btnClear.BackColor = System.Drawing.Color.Gray; this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ucUserManager
            this.Controls.Add(this.gbAddUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucUserManager";
            this.Size = new System.Drawing.Size(832, 653);
            this.BackColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.ucUserManager_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbAddUser;
        private System.Windows.Forms.Label lblUsername, lblPassword, lblFullName, lblRole;
        private System.Windows.Forms.TextBox txtUsername, txtPassword, txtFullName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId, ColUsername, ColFullName, ColRoleName, ColRoleId;
    }
}