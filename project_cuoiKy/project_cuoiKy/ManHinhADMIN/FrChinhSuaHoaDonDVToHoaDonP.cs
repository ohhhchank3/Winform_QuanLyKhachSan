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
    public partial class FrChinhSuaHoaDonDVToHoaDonP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtkt = new DataTable();
        DataTable dtdv = new DataTable();
        string sql, sql2,connstr;
        function fn = new function();
        
        int i;
        public FrChinhSuaHoaDonDVToHoaDonP()
        {
            InitializeComponent();
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
              //  Bientoancuc.saveIdHDPhong = int.Parse()
                txttendv.Text = grdPhong[2, i].Value.ToString();
                txtngaygoi.Text = grdPhong[3, i].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grdPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            grdPhong.DataSource = ds.Tables[0];

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtmahdphong.Enabled = true;
            txtngaygoi.Enabled = true;
            txtsoluong.Enabled = true;
            txttendv.Enabled = true;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                String sql1 = "update hoadondv set tendv = N'" + txttendv.Text + "',soluong = " + int.Parse(txtsoluong.Text) + " where idhdp  =" + Bientoancuc.saveIdHDPhong + " and idhddv = " + int.Parse(txtMahoadon.Text) + "";
                fn.setData(sql1);
                String sql4 = "UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv*hoadondv.soluong) from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and hoadondv.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + " ) where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + ";" +
                "UPDATE dbo.hoadonphong SET tiendichvu = 0 where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + " and tiendichvu is null ;" +
                "UPDATE dbo.hoadonphong SET tongtien = (select tienphong + tiendichvu from hoadonphong where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + ") where hoadonphong.idhdp = " + Convert.ToInt32(txtmahdphong.Text) + ";";
                fn.setData(sql4);

                //fn.setData(k);
                MessageBox.Show("Thực hiện load dữ liệu");
                String sqql = "SELECT * from hoadondv where idhdp = " + Bientoancuc.saveIdHDPhong + "";
                loadData(sqql);
                Bientoancuc.saveIdHDPhong = 0;
            }
            catch
            {

            } 
            
      
        
         
         


        }
        
        private void AN()
        {
            txtmahdphong.Enabled = false;
            txtngaygoi.Enabled = false;
            txtsoluong.Enabled = false;
            txttendv.Enabled = false;
        }

        private void FrChinhSuaHoaDonDVToHoaDonP_Load(object sender, EventArgs e)
        {
            try
            {
                connstr = Bientoancuc.TCconnstr;
                conn.ConnectionString = connstr;
                conn.Open();
                AN();
                sql = "SELECT * from hoadondv where idhdp = " + Bientoancuc.saveIdHDPhong + "";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                
                grdPhong.DataSource = dt;
                grdPhong.Refresh();
                //Bientoancuc.saveIdHDPhong = 0;
            }
            catch
            {

            }
           
        }
    }
}
