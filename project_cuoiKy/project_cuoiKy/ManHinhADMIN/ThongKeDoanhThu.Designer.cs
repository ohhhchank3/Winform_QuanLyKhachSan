namespace project_cuoiKy
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnxemrieng = new Guna.UI2.WinForms.Guna2Button();
            this.btnxemthang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnxemtheothang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cmbthang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbnam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnchonca2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnlen = new Guna.UI2.WinForms.Guna2Button();
            this.btnxuong = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 168);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1024, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            this.btnxemrieng.Location = new System.Drawing.Point(408, 117);
            this.btnxemrieng.Name = "btnxemrieng";
            this.btnxemrieng.Size = new System.Drawing.Size(180, 45);
            this.btnxemrieng.TabIndex = 1;
            this.btnxemrieng.Text = "Xem";
            this.btnxemrieng.Click += new System.EventHandler(this.btnxemrieng_Click);
            // 
            // btnxemthang
            // 
            this.btnxemthang.AutoSize = true;
            this.btnxemthang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemthang.CheckedState.BorderThickness = 0;
            this.btnxemthang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemthang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnxemthang.CheckedState.InnerOffset = -4;
            this.btnxemthang.Location = new System.Drawing.Point(304, 12);
            this.btnxemthang.Name = "btnxemthang";
            this.btnxemthang.Size = new System.Drawing.Size(116, 20);
            this.btnxemthang.TabIndex = 2;
            this.btnxemthang.Text = "Xem theo năm ";
            this.btnxemthang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnxemthang.UncheckedState.BorderThickness = 2;
            this.btnxemthang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnxemthang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnxemthang.CheckedChanged += new System.EventHandler(this.btnxemthang_CheckedChanged);
            // 
            // btnxemtheothang
            // 
            this.btnxemtheothang.AutoSize = true;
            this.btnxemtheothang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemtheothang.CheckedState.BorderThickness = 0;
            this.btnxemtheothang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnxemtheothang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnxemtheothang.CheckedState.InnerOffset = -4;
            this.btnxemtheothang.Location = new System.Drawing.Point(516, 12);
            this.btnxemtheothang.Name = "btnxemtheothang";
            this.btnxemtheothang.Size = new System.Drawing.Size(120, 20);
            this.btnxemtheothang.TabIndex = 3;
            this.btnxemtheothang.Text = "Xem theo tháng";
            this.btnxemtheothang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnxemtheothang.UncheckedState.BorderThickness = 2;
            this.btnxemtheothang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnxemtheothang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnxemtheothang.CheckedChanged += new System.EventHandler(this.btnxemtheonam_CheckedChanged);
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
            this.cmbthang.Location = new System.Drawing.Point(401, 38);
            this.cmbthang.Name = "cmbthang";
            this.cmbthang.Size = new System.Drawing.Size(187, 36);
            this.cmbthang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm ";
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
            this.cmbnam.Location = new System.Drawing.Point(401, 80);
            this.cmbnam.Name = "cmbnam";
            this.cmbnam.Size = new System.Drawing.Size(187, 36);
            this.cmbnam.TabIndex = 7;
            // 
            // btnchonca2
            // 
            this.btnchonca2.AutoSize = true;
            this.btnchonca2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnchonca2.CheckedState.BorderThickness = 0;
            this.btnchonca2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnchonca2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnchonca2.CheckedState.InnerOffset = -4;
            this.btnchonca2.Location = new System.Drawing.Point(683, 12);
            this.btnchonca2.Name = "btnchonca2";
            this.btnchonca2.Size = new System.Drawing.Size(102, 20);
            this.btnchonca2.TabIndex = 9;
            this.btnchonca2.Text = "Xem kết hợp";
            this.btnchonca2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnchonca2.UncheckedState.BorderThickness = 2;
            this.btnchonca2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnchonca2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnchonca2.CheckedChanged += new System.EventHandler(this.btnchonca2_CheckedChanged);
            // 
            // btnlen
            // 
            this.btnlen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlen.ForeColor = System.Drawing.Color.White;
            this.btnlen.Location = new System.Drawing.Point(890, 312);
            this.btnlen.Name = "btnlen";
            this.btnlen.Size = new System.Drawing.Size(47, 31);
            this.btnlen.TabIndex = 20;
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
            this.btnxuong.Location = new System.Drawing.Point(955, 312);
            this.btnxuong.Name = "btnxuong";
            this.btnxuong.Size = new System.Drawing.Size(47, 31);
            this.btnxuong.TabIndex = 21;
            this.btnxuong.Text = ">";
            this.btnxuong.Click += new System.EventHandler(this.btnxuong_Click);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_cuoiKy.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.btnxuong);
            this.Controls.Add(this.btnlen);
            this.Controls.Add(this.btnchonca2);
            this.Controls.Add(this.cmbnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbthang);
            this.Controls.Add(this.btnxemtheothang);
            this.Controls.Add(this.btnxemthang);
            this.Controls.Add(this.btnxemrieng);
            this.Controls.Add(this.chart1);
            this.Name = "ThongKeDoanhThu";
            this.Text = "Thống kê Doanh Thu";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Button btnxemrieng;
        private Guna.UI2.WinForms.Guna2RadioButton btnxemthang;
        private Guna.UI2.WinForms.Guna2RadioButton btnxemtheothang;
        private Guna.UI2.WinForms.Guna2ComboBox cmbthang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbnam;
        private Guna.UI2.WinForms.Guna2RadioButton btnchonca2;
        private Guna.UI2.WinForms.Guna2Button btnlen;
        private Guna.UI2.WinForms.Guna2Button btnxuong;
    }
}