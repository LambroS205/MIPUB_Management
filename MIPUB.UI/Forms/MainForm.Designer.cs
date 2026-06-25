namespace MIPUB.UI.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button(); // KHAI BÁO NÚT MỚI
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlSidebar.Controls.Add(this.lblUserInfo);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnQuanLyTaiKhoan); // ADD VÀO PANEL
            this.pnlSidebar.Controls.Add(this.btnThongKe);
            this.pnlSidebar.Controls.Add(this.btnQuanLySach);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(250, 650);

            // lblLogo
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblLogo.Location = new System.Drawing.Point(20, 30);
            this.lblLogo.Text = "MIPUB SYSTEM";

            // btnQuanLySach
            this.btnQuanLySach.FlatAppearance.BorderSize = 0;
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQuanLySach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnQuanLySach.Location = new System.Drawing.Point(0, 120);
            this.btnQuanLySach.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLySach.Size = new System.Drawing.Size(250, 50);
            this.btnQuanLySach.Text = "📚 Quản lý Sách";
            this.btnQuanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);

            // btnThongKe
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnThongKe.Location = new System.Drawing.Point(0, 180);
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 50);
            this.btnThongKe.Text = "📊 Thống kê && Tìm kiếm";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // btnQuanLyTaiKhoan (NÚT MỚI)
            this.btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 240);
            this.btnQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(250, 50);
            this.btnQuanLyTaiKhoan.Text = "👥 Quản lý Tài Khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);

            // btnLogout
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Tomato;
            this.btnLogout.Location = new System.Drawing.Point(0, 580);
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblUserInfo
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblUserInfo.Location = new System.Drawing.Point(20, 520);
            this.lblUserInfo.Size = new System.Drawing.Size(210, 50);

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(250, 0);
            this.pnlMain.Size = new System.Drawing.Size(832, 653);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Sách MIPUB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserInfo;
    }
}