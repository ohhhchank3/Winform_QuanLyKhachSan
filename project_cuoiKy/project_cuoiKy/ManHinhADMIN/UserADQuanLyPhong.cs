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
    public partial class UserADQuanLyPhong : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter d2 = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        string sql, connstr,sql1,sql2;
        String tdonvi, tgiadv;
        bool flag = false;
        int i;
        function fn = new function();

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            i = grddmdv.CurrentRow.Index;
            if (i != 0)
            {
                grddmdv.CurrentCell = grddmdv[0, i - 1];
               NapCT();
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            i = grddmdv.CurrentRow.Index;
            if (i < grddmdv.Rows.Count - 1)
            {
                grddmdv.CurrentCell = grddmdv[0, i + 1];
                NapCT();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            grddmdv.CurrentCell = grddmdv[0, 0];
           NapCT();
        }

        private void grddmdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
          string truyvan = "update dbo.phong set trangthai = N'" + txttt.Text + "',sogiuong = " + int.Parse(txtsogiuong.Text) + ",giaphong = "+float.Parse(txtgiatien.Text)+",loaiphong = N'"+txtloai.Text+ "'  where idphong = '" + txtmaphong.Text + "' ";

            fn.setData(truyvan);
             
        }

        private void grddmdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string truyvan = "update dbo.phong set trangthai = N'" + txttt.Text + "',sogiuong = " + int.Parse(txtsogiuong.Text) + ",giaphong = " + float.Parse(txtgiatien.Text) + ",loaiphong = N'" + txtloai.Text + "'  where idphong = '" + txtmaphong.Text + "' ";
            fn.setData(truyvan);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            grddmdv.CurrentCell = grddmdv[0, grddmdv.Rows.Count - 2];
            NapCT();
        }

        public UserADQuanLyPhong()
        {
            InitializeComponent();
        }
        void NapCT()
        {
            try
            {
                i = grddmdv.CurrentRow.Index;
                txtmaphong.Text = grddmdv[0, i].Value.ToString();
                txtsogiuong.Text = grddmdv[2, i].Value.ToString();
                txtloai.Text = grddmdv[1, i].Value.ToString();
                txttt.Text = grddmdv[3, i].Value.ToString();
                txtgiatien.Text = grddmdv[4, i].Value.ToString();
                string k = txtmaphong.Text;
                sql1 = "select idkh,trangthai,ngaycheckin from PhongDatTruoc1 where idphong = N'" + k.ToString() + "' and [check] = 1";
                da1 = new SqlDataAdapter(sql1, conn);
                dt1.Clear();
                da1.Fill(dt1);
                txtTrangThaiTHueTruoc.Text = Convert.ToString(dt1.Rows[0].ItemArray[1]);
                txtIdkh.Text = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                txtngaytoi.Text = Convert.ToString(dt1.Rows[0].ItemArray[2]);
                string z = txtIdkh.Text;

                sql2 = "select hoten from khachhang where idkh = " + Convert.ToInt16(z.ToString()) + "";
                d2 = new SqlDataAdapter(sql2, conn);
                dt2.Clear();
                d2.Fill(dt2);
                txtHoten.Text = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                k = "";
                z = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tìm thấy phòng này trong danh sách Phòng đặt trước","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                txtTrangThaiTHueTruoc.Text = "";
                txtIdkh.Text = "";
                txtngaytoi.Text = "";
            }
  


        }
        private void UserADQuanLyPhong_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "Select * from dbo.Phong";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddmdv.DataSource = dt;
            grddmdv.Refresh();
        }
    }
}
