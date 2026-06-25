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
            lblTitle = new Label();
            dgvUsers = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColUsername = new DataGridViewTextBoxColumn();
            ColFullName = new DataGridViewTextBoxColumn();
            ColRoleName = new DataGridViewTextBoxColumn();
            ColRoleId = new DataGridViewTextBoxColumn();
            gbAddUser = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblRole = new Label();
            cbRole = new ComboBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { ColId, ColUsername, ColFullName, ColRoleName, ColRoleId });
            dgvUsers.Location = new Point(27, 80);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(780, 340);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // ColId
            // 
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            // 
            // ColUsername
            // 
            ColUsername.HeaderText = "Tên đăng nhập";
            ColUsername.MinimumWidth = 6;
            ColUsername.Name = "ColUsername";
            ColUsername.ReadOnly = true;
            // 
            // ColFullName
            // 
            ColFullName.HeaderText = "Họ và Tên";
            ColFullName.MinimumWidth = 6;
            ColFullName.Name = "ColFullName";
            ColFullName.ReadOnly = true;
            // 
            // ColRoleName
            // 
            ColRoleName.HeaderText = "Vai trò (Role)";
            ColRoleName.MinimumWidth = 6;
            ColRoleName.Name = "ColRoleName";
            ColRoleName.ReadOnly = true;
            // 
            // ColRoleId
            // 
            ColRoleId.MinimumWidth = 6;
            ColRoleId.Name = "ColRoleId";
            ColRoleId.ReadOnly = true;
            ColRoleId.Visible = false;
            // 
            // gbAddUser
            // 
            gbAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddUser.Controls.Add(cbRole);
            gbAddUser.Controls.Add(txtPassword);
            gbAddUser.Controls.Add(txtFullName);
            gbAddUser.Controls.Add(txtUsername);
            gbAddUser.Controls.Add(btnClear);
            gbAddUser.Controls.Add(btnDelete);
            gbAddUser.Controls.Add(btnUpdate);
            gbAddUser.Controls.Add(btnAdd);
            gbAddUser.Controls.Add(lblRole);
            gbAddUser.Controls.Add(lblFullName);
            gbAddUser.Controls.Add(lblPassword);
            gbAddUser.Controls.Add(lblUsername);
            gbAddUser.Location = new Point(27, 440);
            gbAddUser.Name = "gbAddUser";
            gbAddUser.Size = new Size(780, 180);
            gbAddUser.TabIndex = 0;
            gbAddUser.TabStop = false;
            gbAddUser.Text = "Thông tin chi tiết";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(480, 130);
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
            btnDelete.Location = new Point(360, 130);
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
            btnUpdate.Location = new Point(240, 130);
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
            btnAdd.Location = new Point(120, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblRole
            // 
            lblRole.Location = new Point(380, 80);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Vai trò:";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Location = new Point(460, 77);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 28);
            cbRole.TabIndex = 5;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(30, 80);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(120, 77);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(380, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(460, 37);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 9;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 40);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 11;
            // 
            // ucUserManager
            // 
            BackColor = Color.White;
            Controls.Add(gbAddUser);
            Controls.Add(dgvUsers);
            Controls.Add(lblTitle);
            Name = "ucUserManager";
            Size = new Size(832, 653);
            Load += ucUserManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbAddUser.ResumeLayout(false);
            gbAddUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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