namespace project_cuoiKy
{
    partial class ADTimkiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADTimkiem));
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.grdPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTT = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSogiuong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhong)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(772, 504);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Chọn";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(772, 362);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Tìm kiếm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // grdPhong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPhong.BackgroundColor = System.Drawing.Color.White;
            this.grdPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPhong.ColumnHeadersHeight = 30;
            this.grdPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPhong.EnableHeadersVisualStyles = false;
            this.grdPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdPhong.Location = new System.Drawing.Point(2, 39);
            this.grdPhong.Name = "grdPhong";
            this.grdPhong.RowHeadersVisible = false;
            this.grdPhong.RowHeadersWidth = 51;
            this.grdPhong.RowTemplate.Height = 24;
            this.grdPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPhong.Size = new System.Drawing.Size(658, 528);
            this.grdPhong.TabIndex = 4;
            this.grdPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.grdPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdPhong.ThemeStyle.HeaderStyle.Height = 30;
            this.grdPhong.ThemeStyle.ReadOnly = false;
            this.grdPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdPhong.ThemeStyle.RowsStyle.Height = 24;
            this.grdPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idphong";
            this.Column1.HeaderText = "Số phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "loaiphong";
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sogiuong";
            this.Column3.HeaderText = "Số giường";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "trangthai";
            this.Column4.HeaderText = "Trạng thái ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "giaphong";
            this.Column5.HeaderText = "Giá tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // txtTT
            // 
            this.txtTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTT.DefaultText = "";
            this.txtTT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTT.Location = new System.Drawing.Point(172, 44);
            this.txtTT.Name = "txtTT";
            this.txtTT.PasswordChar = '\0';
            this.txtTT.PlaceholderText = "";
            this.txtTT.SelectedText = "";
            this.txtTT.Size = new System.Drawing.Size(200, 36);
            this.txtTT.TabIndex = 0;
            // 
            // cbLoai
            // 
            this.cbLoai.AutoCompleteCustomSource.AddRange(new string[] {
            "Thường",
            "Vip"});
            this.cbLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoai.ItemHeight = 30;
            this.cbLoai.Items.AddRange(new object[] {
            "Thường",
            "Vip"});
            this.cbLoai.Location = new System.Drawing.Point(172, 114);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(200, 36);
            this.cbLoai.TabIndex = 6;
            // 
            // cbSogiuong
            // 
            this.cbSogiuong.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.cbSogiuong.BackColor = System.Drawing.Color.Transparent;
            this.cbSogiuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSogiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSogiuong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSogiuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSogiuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSogiuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSogiuong.ItemHeight = 30;
            this.cbSogiuong.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSogiuong.Location = new System.Drawing.Point(172, 192);
            this.cbSogiuong.Name = "cbSogiuong";
            this.cbSogiuong.Size = new System.Drawing.Size(200, 36);
            this.cbSogiuong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số giường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Loại phòng";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.cbSogiuong);
            this.guna2GroupBox1.Controls.Add(this.cbLoai);
            this.guna2GroupBox1.Controls.Add(this.txtTT);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(666, 39);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(375, 300);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Thông tin phòng";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 210);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 18);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Số giường";
            // 
            // ADTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.grdPhong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADTimkiem";
            this.Text = "Tìm kiếm ";
            this.Load += new System.EventHandler(this.ADTimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhong)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView grdPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2TextBox txtTT;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cbSogiuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}