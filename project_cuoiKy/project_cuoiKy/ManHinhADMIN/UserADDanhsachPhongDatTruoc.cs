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
    public partial class UserADDanhsachPhongDatTruoc : UserControl
    {
        function fn = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql,sql11, connstr, timkiem;
        int i, sl;

        private void grdPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        public void LoadDaTa(String qur)
        {
            DataSet ds = fn.getData(qur);
            grdPhong.DataSource = ds.Tables[0];
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            //   string z =txtNgaytoi.ToString("dd-MM-yyyy");
            string ngayden = dtpngayden.Value.ToString("yyyy-MM-dd");
            String sql1 = "update dbo.PhongDatTruoc1 set idphong = '"+txtMaPhong.Text+"',trangthai = N'"+txttrangthai.Text+"',ngaycheckin = '"+ngayden+"',[check] = "+Convert.ToInt16(txtcheck.Text)+" where idkh = "+int.Parse(txtId.Text)+" and SoTT = "+int.Parse(txtSoTT.Text)+" ";
            fn.setData(sql1);
            MessageBox.Show("Thực hiện LoadData");
            String sqlaa = "SELECT * FROM dbo.PhongDatTruoc1";
            LoadDaTa(sqlaa);
            MessageBox.Show("Thực hiện cập nhật thành công");
            sql = "SELECT * FROM dbo.PhongDatTruoc1";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
        }

        private void grdPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        public UserADDanhsachPhongDatTruoc()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            //dt.Clear();
            i = grdPhong.CurrentRow.Index;
            txtId.Text = grdPhong[0, i].Value.ToString();
            
            //txthoten.Text = grdPhong[1,i].Value.ToString();
            txtMaPhong.Text = grdPhong[1,i].Value.ToString();
            dtpngayden.MinDate = DateTime.Parse(grdPhong[3, i].Value.ToString());
            txtSoTT.Text = grdPhong[4,i].Value.ToString();
            txttrangthai.Text = grdPhong[2, i].Value.ToString();
            txtcheck.Text = grdPhong[5,i].Value.ToString();
            string k = txtId.Text;

            sql11 = "select hoten,cmnd,diachi from khachhang where idkh = "+Convert.ToInt16(k.ToString())+"";
            da1 = new SqlDataAdapter(sql11, conn);
            da1.Fill(dt1);
            txthoten.Text =Convert.ToString( dt1.Rows[0].ItemArray[0]);
            txtcmnd.Text = Convert.ToString(dt1.Rows[0].ItemArray[1]);
            txtdiachi.Text = Convert.ToString(dt1.Rows[0].ItemArray[2]);
            k = "";
            dt1.Clear();
        }
        private void UserADDanhsachPhongDatTruoc_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT * FROM dbo.PhongDatTruoc1";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
            txtId.Enabled = false;
            txthoten.Enabled = false;
            txtdiachi.Enabled = false;
            txtcmnd.Enabled = false;
            txtSoTT.Enabled = false;
        }
    }
}
