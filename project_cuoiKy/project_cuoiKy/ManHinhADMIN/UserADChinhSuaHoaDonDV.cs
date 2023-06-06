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
    public partial class UserADChinhSuaHoaDonDV : UserControl
    {
        function fn = new function();
        function fn1 = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtkt = new DataTable();
        string sql, connstr;
        int i;
        public UserADChinhSuaHoaDonDV()
        {
            InitializeComponent();
        }

        private void grdPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        public void NapCT()
        {
            try
            {
                //  i = grdkhachhang1.CurrentRow.Index;
                //   txtcmnd.Text = grdkhachhang1[0, i].Value.ToString();
                // txtHoTen.Text = grdkhachhang1[1, i].Value.ToString();
                //   txtDiachi.Text = grdkhachhang1[2, i].Value.ToString();
                i = grdPhong.CurrentRow.Index;
               txtMahoadon.Text = grdPhong[0, i].Value.ToString();
                txtsoluong.Text = grdPhong[4, i].Value.ToString();
           txtmahdphong.Text = grdPhong[1, i].Value.ToString();
            
           txttendv.Text = grdPhong[2, i].Value.ToString();
           txtngaygoi.Text = grdPhong[3, i].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            sql = "SELECT idhddv,idhdp,tendv,ngaygoi,soluong from hoadondv where idhdp = "+int.Parse(txttiemkiem.Text)+"  or idhddv = "+int.Parse(txttiemkiem.Text)+" ";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            String sql2 = "update hoadondv set idhdp = " + int.Parse(txtmahdphong.Text) + ",tendv = N'"+txttendv.Text+"',soluong = "+int.Parse(txtsoluong.Text)+" where idhddv = "+int.Parse(txtMahoadon.Text)+" ";
            fn.setData(sql2);
            String sql4 = "UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv*hoadondv.soluong) from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and hoadondv.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + " ) where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + ";" +
              "UPDATE dbo.hoadonphong SET tiendichvu = 0 where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + " and tiendichvu is null ;" +
              "UPDATE dbo.hoadonphong SET tongtien = (select tienphong + tiendichvu from hoadonphong where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + ") where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + ";";
            fn1.setData(sql4);
                //" UPDATE dbo.hoadonphong SET tienphong = (select phong.giaphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and hoado
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Hien();
        }
        private void Hien()
        {
            txtmahdphong.Enabled = true;
            // txtMahoadon.Visible = false;
            txtngaygoi.Enabled = true;
            txtsoluong.Enabled = true;
            txttendv.Enabled = true;
        }
        private void AN()
        {
            txtmahdphong.Enabled = false;
           // txtMahoadon.Visible = false;
            txtngaygoi.Enabled = false;
            txtsoluong.Enabled = false;
            txttendv.Enabled = false;
         
            
        }
        private void UserADChinhSuaHoaDonDV_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT * from hoadondv";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
            txtMahoadon.Enabled = false;
            txtngaygoi.Enabled = false;
            AN();
        }
    }
}
