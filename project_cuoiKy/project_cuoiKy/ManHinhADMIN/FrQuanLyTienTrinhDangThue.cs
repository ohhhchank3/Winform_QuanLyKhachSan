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
    public partial class FrQuanLyTienTrinhDangThue : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        string sql, connstr, timkiem, sql1, sql2;
        int i, idhdp;
        string maphong;
        function fn = new function();
        public FrQuanLyTienTrinhDangThue()
        {
            InitializeComponent();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void dtgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dt1.Clear();
            dt2.Clear();
            i = dtgPhong.CurrentRow.Index;
            maphong = dtgPhong[0, i].Value.ToString();
            NapLan1(maphong);
            maphong = "";
            label1.Text = dtgPhong[0, i].Value.ToString();
            txttienPhong.Text = dtgPhong[4,i].Value.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void FrQuanLyTienTrinhDangThue_Load(object sender, EventArgs e)
        {

            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "select * from Phong where trangthai = N'Có người'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dtgPhong.DataSource = dt;
            dtgPhong.Refresh();
             
        }
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            grdPhong.DataSource = ds.Tables[0];

        }
        private void NapLan1(string k)
        {
            try
            {
                sql1 = "select idhdp,idkh,ngaycheckin  from hoadonphong where ngaycheckout is null and idphong = N'" + maphong + "' ";
                da1 = new SqlDataAdapter(sql1, conn);
                //dt1.Clear();
                da1.Fill(dt1);
                txtMaHoaDon.Text = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                
                txtID.Text = Convert.ToString(dt1.Rows[0].ItemArray[1]);
                txtngaycheckin.Text = Convert.ToString(dt1.Rows[0].ItemArray[2]);
                string t = txtID.Text;
                string mahoadon = txtMaHoaDon.Text;
                //
                dt2.Clear();
                sql2 = "select hoten,diachi from khachhang where idkh = "+Convert.ToInt16(t.ToString())+"";
                da2= new SqlDataAdapter (sql2, conn);
                da2.Fill(dt2);
                txthhoten.Text = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                txttdiachi.Text = Convert.ToString(dt2.Rows[0].ItemArray[1]);
                String sql111 = "select * from hoadondv where idhdp = " + Convert.ToInt16(mahoadon.ToString()) + "";
                loadData(sql111);
                mahoadon = "";
                t = "";

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
           
           // k = "";
            
        }
    }
}
