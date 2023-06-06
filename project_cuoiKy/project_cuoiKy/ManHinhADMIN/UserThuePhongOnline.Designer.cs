namespace project_cuoiKy
{
    partial class UserThuePhongOnline
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnchonca2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cmbnam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbthang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnxemtheothang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnxemtheonam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnxemrieng = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsosanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthieusuat = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbthang = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnlen = new Guna.UI2.WinForms.Guna2Button();
            this.btnxuong = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 330);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Giá trị";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1046, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnchonca2
            // 
            this.btnchonca2.AutoSize = true;
            this.btnchonca2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnchonca2.CheckedState.BorderThickness = 0;
            this.btnchonca2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnchonca2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnchonca2.CheckedState.InnerOffset = -4;
            this.btnchonca2.Location = new System.Drawing.Point(647, 3);
            this.btnchonca2.Name = "btnchonca2";
            this.btnchonca2.Size = new System.Drawing.Size(102, 20);
            this.btnchonca2.TabIndex = 24;
            this.btnchonca2.Text = "Xem kết hợp";
            this.btnchonca2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnchonca2.UncheckedState.BorderThickness = 2;
            this.btnchonca2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnchonca2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cmbnam
            // 
            this.cmbnam.BackColor = System.Drawing.Color.Transparent;
            this.cmbnam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbnam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbnam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbnam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbnam.ItemHeight = 30;
            this.cmbnam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.cmbnam.Location = new System.Drawing.Point(367, 71);
            this.cmbnam.Name = "cmbnam";
            this.cmbnam.Size = new System.Drawing.Size(187, 36);
            this.cmbnam.TabIndex = 23;
            this.cmbnam.SelectedIndexChanged += new System.EventHandler(this.cmbnam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tháng";
            // 
            // cmbthang
            // 
            this.cmbthang.BackColor = System.Drawing.Color.Transparent;
            this.cmbthang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbthang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbthang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbthang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbthang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbthang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbthang.ItemHeight = 30;
            this.cmbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbthang.Location = new System.Drawing.Point(367, 29);
            this.cmbthang.Name = "cmbthang";
            this.cmbthang.Size = new System.Drawing.Size(187, 36);
            this.cmbthang.TabIndex = 21;
            this.cmbthang.SelectedIndexChanged += new System.EventHandler(this.cmbthang_SelectedIndexChanged);
            // 
            // btnxemtheothang
            // 
            this.btnxemtheothang.AutoSize = true;
            this.btnxemtheothang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemtheothang.CheckedState.BorderThickness = 0;
            this.btnxemtheothang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemtheothang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnxemtheothang.CheckedState.InnerOffset = -4;
            this.btnxemtheothang.Location = new System.Drawing.Point(479, 3);
            this.btnxemtheothang.Name = "btnxemtheothang";
            this.btnxemtheothang.Size = new System.Drawing.Size(120, 20);
            this.btnxemtheothang.TabIndex = 20;
            this.btnxemtheothang.Text = "Xem theo tháng";
            this.btnxemtheothang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnxemtheothang.UncheckedState.BorderThickness = 2;
            this.btnxemtheothang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnxemtheothang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnxemtheothang.CheckedChanged += new System.EventHandler(this.btnxemtheothang_CheckedChanged);
            // 
            // btnxemtheonam
            // 
            this.btnxemtheonam.AutoSize = true;
            this.btnxemtheonam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemtheonam.CheckedState.BorderThickness = 0;
            this.btnxemtheonam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemtheonam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnxemtheonam.CheckedState.InnerOffset = -4;
            this.btnxemtheonam.Location = new System.Drawing.Point(270, 3);
            this.btnxemtheonam.Name = "btnxemtheonam";
            this.btnxemtheonam.Size = new System.Drawing.Size(116, 20);
            this.btnxemtheonam.TabIndex = 19;
            this.btnxemtheonam.Text = "Xem theo năm ";
            this.btnxemtheonam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnxemtheonam.UncheckedState.BorderThickness = 2;
            this.btnxemtheonam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnxemtheonam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnxemtheonam.CheckedChanged += new System.EventHandler(this.btnxemtheonam_CheckedChanged);
            // 
            // btnxemrieng
            // 
            this.btnxemrieng.BorderRadius = 12;
            this.btnxemrieng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxemrieng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxemrieng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxemrieng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxemrieng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxemrieng.ForeColor = System.Drawing.Color.White;
            this.btnxemrieng.Location = new System.Drawing.Point(593, 49);
            this.btnxemrieng.Name = "btnxemrieng";
            this.btnxemrieng.Size = new System.Drawing.Size(180, 45);
            this.btnxemrieng.TabIndex = 18;
            this.btnxemrieng.Text = "Xem";
            this.btnxemrieng.Click += new System.EventHandler(this.btnxemrieng_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Năm ";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txtsosanh);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.txthieusuat);
            this.guna2GroupBox1.Controls.Add(this.lbthang);
            this.guna2GroupBox1.Controls.Add(this.lbten);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtTongSoLuong);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 128);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1030, 196);
            this.guna2GroupBox1.TabIndex = 26;
            this.guna2GroupBox1.Text = "Thông tin chi tiết ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(486, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "...";
            // 
            // txtsosanh
            // 
            this.txtsosanh.BorderRadius = 12;
            this.txtsosanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsosanh.DefaultText = "";
            this.txtsosanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsosanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsosanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsosanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsosanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsosanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsosanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsosanh.Location = new System.Drawing.Point(778, 89);
            this.txtsosanh.Name = "txtsosanh";
            this.txtsosanh.PasswordChar = '\0';
            this.txtsosanh.PlaceholderText = "";
            this.txtsosanh.SelectedText = "";
            this.txtsosanh.Size = new System.Drawing.Size(89, 36);
            this.txtsosanh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hiệu suất";
            // 
            // txthieusuat
            // 
            this.txthieusuat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthieusuat.DefaultText = "";
            this.txthieusuat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthieusuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthieusuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthieusuat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthieusuat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthieusuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthieusuat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthieusuat.Location = new System.Drawing.Point(228, 89);
            this.txthieusuat.Name = "txthieusuat";
            this.txthieusuat.PasswordChar = '\0';
            this.txthieusuat.PlaceholderText = "";
            this.txthieusuat.SelectedText = "";
            this.txthieusuat.Size = new System.Drawing.Size(89, 36);
            this.txthieusuat.TabIndex = 4;
            // 
            // lbthang
            // 
            this.lbthang.AutoSize = true;
            this.lbthang.Location = new System.Drawing.Point(233, 10);
            this.lbthang.Name = "lbthang";
            this.lbthang.Size = new System.Drawing.Size(18, 20);
            this.lbthang.TabIndex = 3;
            this.lbthang.Text = "...";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(156, 10);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(18, 20);
            this.lbten.TabIndex = 2;
            this.lbten.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số lượng thuê Phòng ";
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongSoLuong.DefaultText = "";
            this.txtTongSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongSoLuong.Location = new System.Drawing.Point(228, 47);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.PasswordChar = '\0';
            this.txtTongSoLuong.PlaceholderText = "";
            this.txtTongSoLuong.SelectedText = "";
            this.txtTongSoLuong.Size = new System.Drawing.Size(128, 36);
            this.txtTongSoLuong.TabIndex = 0;
            // 
            // btnlen
            // 
            this.btnlen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlen.ForeColor = System.Drawing.Color.White;
            this.btnlen.Location = new System.Drawing.Point(931, 461);
            this.btnlen.Name = "btnlen";
            this.btnlen.Size = new System.Drawing.Size(47, 31);
            this.btnlen.TabIndex = 27;
            this.btnlen.Text = "<";
            this.btnlen.Click += new System.EventHandler(this.btnlen_Click);
            // 
            // btnxuong
            // 
            this.btnxuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxuong.ForeColor = System.Drawing.Color.White;
            this.btnxuong.Location = new System.Drawing.Point(995, 461);
            this.btnxuong.Name = "btnxuong";
            this.btnxuong.Size = new System.Drawing.Size(47, 31);
            this.btnxuong.TabIndex = 28;
            this.btnxuong.Text = ">";
            this.btnxuong.Click += new System.EventHandler(this.btnxuong_Click);
            // 
            // UserThuePhongOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnxuong);
            this.Controls.Add(this.btnlen);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchonca2);
            this.Controls.Add(this.cmbnam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbthang);
            this.Controls.Add(this.btnxemtheothang);
            this.Controls.Add(this.btnxemtheonam);
            this.Controls.Add(this.btnxemrieng);
            this.Controls.Add(this.chart1);
            this.Name = "UserThuePhongOnline";
            this.Size = new System.Drawing.Size(1061, 653);
            this.Load += new System.EventHandler(this.UserThuePhongOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2RadioButton btnchonca2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbnam;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbthang;
        private Guna.UI2.WinForms.Guna2RadioButton btnxemtheothang;
        private Guna.UI2.WinForms.Guna2RadioButton btnxemtheonam;
        private Guna.UI2.WinForms.Guna2Button btnxemrieng;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtsosanh;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txthieusuat;
        private System.Windows.Forms.Label lbthang;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTongSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnlen;
        private Guna.UI2.WinForms.Guna2Button btnxuong;
    }
}
