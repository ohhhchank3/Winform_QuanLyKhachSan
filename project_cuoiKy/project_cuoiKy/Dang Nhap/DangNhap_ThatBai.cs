using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cuoiKy
{
    public partial class DangNhap_ThatBai : Form
    {
        int i, n;
        public DangNhap_ThatBai()
        {
            InitializeComponent();
        }

        private void timeCOnlai_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Maximum = n;
            i--;
            this.label2.Text = "Thời gian chờ : " + i.ToString() + " Giây";
            if (i > 0)
            {
                guna2ProgressBar1.Value = i;
           
            }
            if (i < 0)
            {
                this.timeCOnlai.Enabled = false;
                // DangNhap test = new DangNhap();
                //  test.Show();
                this.Close();
                //this.Hide();
            }
            guna2WinProgressIndicator1.AutoStart = true;
        }

        private void guna2WinProgressIndicator1_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_ThatBai_Load(object sender, EventArgs e)
        {
            this.timeCOnlai.Enabled = true;
            i = 60;
            n = i;
        }
    }
}
