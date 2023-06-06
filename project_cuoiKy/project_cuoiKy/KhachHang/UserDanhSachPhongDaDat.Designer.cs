namespace project_cuoiKy
{
    partial class UserDanhSachPhongDaDat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grdPhong = new System.Windows.Forms.DataGridView();
            this.idphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 52;
            this.button2.Text = "Tìm Kiếm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(396, 599);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(168, 36);
            this.txtTimKiem.TabIndex = 51;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(788, 587);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 46);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // grdPhong
            // 
            this.grdPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphong,
            this.hoten,
            this.ngaycheckin,
            this.cmnd,
            this.Column1});
            this.grdPhong.Location = new System.Drawing.Point(209, 31);
            this.grdPhong.Margin = new System.Windows.Forms.Padding(4);
            this.grdPhong.Name = "grdPhong";
            this.grdPhong.ReadOnly = true;
            this.grdPhong.RowHeadersWidth = 62;
            this.grdPhong.Size = new System.Drawing.Size(663, 545);
            this.grdPhong.TabIndex = 49;
            // 
            // idphong
            // 
            this.idphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idphong.DataPropertyName = "idphong";
            this.idphong.HeaderText = "Số phòng";
            this.idphong.MinimumWidth = 8;
            this.idphong.Name = "idphong";
            this.idphong.ReadOnly = true;
            this.idphong.Width = 94;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 93;
            // 
            // ngaycheckin
            // 
            this.ngaycheckin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaycheckin.DataPropertyName = "ngaycheckin";
            this.ngaycheckin.HeaderText = "Ngày đến";
            this.ngaycheckin.MinimumWidth = 8;
            this.ngaycheckin.Name = "ngaycheckin";
            this.ngaycheckin.ReadOnly = true;
            this.ngaycheckin.Width = 95;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND/CC";
            this.cmnd.MinimumWidth = 8;
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            this.cmnd.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "trangthai";
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // UserDanhSachPhongDaDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grdPhong);
            this.Name = "UserDanhSachPhongDaDat";
            this.Size = new System.Drawing.Size(1080, 667);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView grdPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
