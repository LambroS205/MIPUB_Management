namespace MIPUB.UI.Forms
{
    partial class ucStatistics
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
            this.gbDemSach = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblCountResult = new System.Windows.Forms.Label();
            this.gbTacGia = new System.Windows.Forms.GroupBox();
            this.btnFindAuthor = new System.Windows.Forms.Button();
            this.lblAuthorResult = new System.Windows.Forms.Label();
            this.lstBooksOfAuthor = new System.Windows.Forms.ListBox();
            this.gbDemSach.SuspendLayout();
            this.gbTacGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ";
            // 
            // gbDemSach
            // 
            this.gbDemSach.Controls.Add(this.lblCountResult);
            this.gbDemSach.Controls.Add(this.btnCount);
            this.gbDemSach.Controls.Add(this.txtYear);
            this.gbDemSach.Controls.Add(this.lblYear);
            this.gbDemSach.Location = new System.Drawing.Point(27, 80);
            this.gbDemSach.Name = "gbDemSach";
            this.gbDemSach.Size = new System.Drawing.Size(750, 150);
            this.gbDemSach.TabIndex = 1;
            this.gbDemSach.TabStop = false;
            this.gbDemSach.Text = "1. Đếm sách xuất bản theo năm";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(30, 50);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 20);
            this.lblYear.Text = "Nhập năm:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(120, 47);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 27);
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCount.ForeColor = System.Drawing.Color.White;
            this.btnCount.Location = new System.Drawing.Point(240, 43);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(94, 34);
            this.btnCount.Text = "Thống kê";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblCountResult
            // 
            this.lblCountResult.AutoSize = true;
            this.lblCountResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCountResult.Location = new System.Drawing.Point(30, 100);
            this.lblCountResult.Name = "lblCountResult";
            this.lblCountResult.Size = new System.Drawing.Size(87, 25);
            this.lblCountResult.Text = "Kết quả: ";
            // 
            // gbTacGia
            // 
            this.gbTacGia.Controls.Add(this.lstBooksOfAuthor);
            this.gbTacGia.Controls.Add(this.lblAuthorResult);
            this.gbTacGia.Controls.Add(this.btnFindAuthor);
            this.gbTacGia.Location = new System.Drawing.Point(27, 260);
            this.gbTacGia.Name = "gbTacGia";
            this.gbTacGia.Size = new System.Drawing.Size(750, 350);
            this.gbTacGia.TabIndex = 2;
            this.gbTacGia.TabStop = false;
            this.gbTacGia.Text = "2. Tìm tác giả có nhiều sách xuất bản nhất";
            // 
            // btnFindAuthor
            // 
            this.btnFindAuthor.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFindAuthor.ForeColor = System.Drawing.Color.White;
            this.btnFindAuthor.Location = new System.Drawing.Point(30, 40);
            this.btnFindAuthor.Name = "btnFindAuthor";
            this.btnFindAuthor.Size = new System.Drawing.Size(200, 40);
            this.btnFindAuthor.Text = "Truy vấn Tác giả Top 1";
            this.btnFindAuthor.UseVisualStyleBackColor = false;
            this.btnFindAuthor.Click += new System.EventHandler(this.btnFindAuthor_Click);
            // 
            // lblAuthorResult
            // 
            this.lblAuthorResult.Location = new System.Drawing.Point(30, 100);
            this.lblAuthorResult.Name = "lblAuthorResult";
            this.lblAuthorResult.Size = new System.Drawing.Size(700, 60);
            this.lblAuthorResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorResult.Text = "Kết quả sẽ hiển thị ở đây...";
            // 
            // lstBooksOfAuthor
            // 
            this.lstBooksOfAuthor.FormattingEnabled = true;
            this.lstBooksOfAuthor.ItemHeight = 20;
            this.lstBooksOfAuthor.Location = new System.Drawing.Point(30, 170);
            this.lstBooksOfAuthor.Name = "lstBooksOfAuthor";
            this.lstBooksOfAuthor.Size = new System.Drawing.Size(700, 164);
            // 
            // ucStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbTacGia);
            this.Controls.Add(this.gbDemSach);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucStatistics";
            this.Size = new System.Drawing.Size(832, 653);
            this.gbDemSach.ResumeLayout(false);
            this.gbDemSach.PerformLayout();
            this.gbTacGia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbDemSach;
        private System.Windows.Forms.Label lblCountResult;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox gbTacGia;
        private System.Windows.Forms.Button btnFindAuthor;
        private System.Windows.Forms.Label lblAuthorResult;
        private System.Windows.Forms.ListBox lstBooksOfAuthor;
    }
}