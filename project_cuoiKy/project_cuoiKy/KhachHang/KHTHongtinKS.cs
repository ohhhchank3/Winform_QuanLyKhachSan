using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_cuoiKy
{
    public partial class KHTHongtinKS : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        string sql, connstr;
  
        string typepic; //Lưu type của ảnh (png, jpg, ...)
        string pathstring; //Lưu đường dẫn để file ảnh
        private void btncaidatlai_Click(object sender, EventArgs e)
        {
            txttenks.Text = "";
            txttenchuks.Text = "";
            txtdiachi.Text = "";
            txtmasothue.Text = "";
            txtsdt.Text = "";
            grbchinh.Enabled = true;
          //  btncapnhat.Enabled = true;
            txttenks.Focus();
        }
        public KHTHongtinKS()
        {
            InitializeComponent();
        }

        private void KHTHongtinKS_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            txttenks.Text = Bientoancuc.tenks;
            txttenchuks.Text = Bientoancuc.tenchuks;
            txtdiachi.Text = Bientoancuc.diachi;
            txtmasothue.Text = Bientoancuc.masothue;
            txtsdt.Text = Bientoancuc.sdt;
            dtpngaythanhlap.Value = Bientoancuc.ngaythanhlap;
            dtpngaythanhlap.MaxDate = DateTime.Now;
            //Load ảnh
            pathstring = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            pathstring = pathstring.Substring(6);
        }
    }
}
