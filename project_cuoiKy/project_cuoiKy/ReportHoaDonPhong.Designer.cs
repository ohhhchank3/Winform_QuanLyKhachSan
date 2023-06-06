namespace project_cuoiKy
{
    partial class ReportHoaDonPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportHoaDonPhong));
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.LocalReport.ReportEmbeddedResource = "project_cuoiKy.BaoCaoDoanhThu.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(3, 48);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(1244, 430);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(545, 51);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 37);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Xem";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // dtp2
            // 
            this.dtp2.Checked = true;
            this.dtp2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp2.Location = new System.Drawing.Point(778, 12);
            this.dtp2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 36);
            this.dtp2.TabIndex = 7;
            this.dtp2.Value = new System.DateTime(2022, 6, 17, 9, 30, 40, 244);
            // 
            // dtp1
            // 
            this.dtp1.Checked = true;
            this.dtp1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp1.Location = new System.Drawing.Point(327, 21);
            this.dtp1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 36);
            this.dtp1.TabIndex = 6;
            this.dtp1.Value = new System.DateTime(2022, 6, 17, 9, 30, 37, 777);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-323, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn thời gian bạn muốn xem ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.dtp2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.dtp1);
            this.guna2Panel1.Location = new System.Drawing.Point(13, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1250, 100);
            this.guna2Panel1.TabIndex = 10;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.rptViewer);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 109);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1250, 481);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chọn thời gian cần xem ";
            // 
            // ReportHoaDonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 602);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportHoaDonPhong";
            this.Text = "Báo cáo hóa đơn phòng";
            this.Load += new System.EventHandler(this.ReportHoaDonPhong_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}