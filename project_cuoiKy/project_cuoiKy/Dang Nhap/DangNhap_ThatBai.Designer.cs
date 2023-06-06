namespace project_cuoiKy
{
    partial class DangNhap_ThatBai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap_ThatBai));
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeCOnlai = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Location = new System.Drawing.Point(12, 227);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.Size = new System.Drawing.Size(610, 30);
            this.guna2ProgressBar1.TabIndex = 1;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(263, 99);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(90, 79);
            this.guna2WinProgressIndicator1.TabIndex = 2;
            this.guna2WinProgressIndicator1.Click += new System.EventHandler(this.guna2WinProgressIndicator1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(121, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vui lòng chờ cho đến khi hết thời gian !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // timeCOnlai
            // 
            this.timeCOnlai.Interval = 1000;
            this.timeCOnlai.Tick += new System.EventHandler(this.timeCOnlai_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(216, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng nhập thất bại";
            // 
            // DangNhap_ThatBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_cuoiKy.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2WinProgressIndicator1);
            this.Controls.Add(this.guna2ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap_ThatBai";
            this.Text = "Màn hình chờ";
            this.Load += new System.EventHandler(this.DangNhap_ThatBai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timeCOnlai;
        private System.Windows.Forms.Label label3;
    }
}