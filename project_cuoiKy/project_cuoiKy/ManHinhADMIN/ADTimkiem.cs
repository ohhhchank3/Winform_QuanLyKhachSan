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
    public partial class ADTimkiem : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string sql, connstr;
        int i;
        string tt, sogiuong, loai;
        string sophong;
        public ADTimkiem()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            i = grdPhong.CurrentRow.Index;
            label1.Text = grdPhong[0, i].Value.ToString();
            TruyenData(label1.Text);
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tt = txtTT.Text;
            sogiuong = cbSogiuong.SelectedItem.ToString();
            loai = cbLoai.SelectedItem.ToString();
            sql = "SELECT * FROM dbo.phong WHERE trangthai LIKE N'%" + tt + "%' AND sogiuong LIKE N'%" + sogiuong + "%' AND loaiphong LIKE N'%" + loai + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
        }

        public delegate void TruyenChoCha(string s);
        public TruyenChoCha TruyenData;
        private void ADTimkiem_Load(object sender, EventArgs e)
        {
            cbLoai.SelectedIndex = 0;
            cbSogiuong.SelectedIndex = 0;
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT * FROM dbo.phong WHERE trangthai = N'Trống'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
        }
    }
}
