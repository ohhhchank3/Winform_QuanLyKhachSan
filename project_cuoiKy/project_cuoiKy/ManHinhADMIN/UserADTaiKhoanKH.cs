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
    public partial class UserADTaiKhoanKH : UserControl
    {
        function fn = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtcmb = new DataTable();
        DataTable dtrpt = new DataTable();
        string sql, connstr;
        String query;
        int k;
        public UserADTaiKhoanKH()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
       
        private void Check(int stt)
        {
            string s = "select IdTaiKhoan from TAIKHOAN ";
            
            da = new SqlDataAdapter(s, conn);
            dt.Clear();
            da.Fill(dt);
            for(int i =0;i<dt.Rows.Count;i++)
            {
                if(stt == (Convert.ToInt16(dt.Rows[i][0])))
                  {
                    stt = rnd.Next(10, 2000);
                   }
            }    
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int k = rnd.Next(100, 2000);
            Check(k);
           
            string sql1 = "SET IDENTITY_INSERT dbo.khachhang on ;" +
                "insert into khachhang(idkh) values (" +k +")";
            cmd = new SqlCommand(sql1,conn);
            cmd.ExecuteNonQuery();

            String s1 = "insert into TAIKHOAN(TaiKhoan,MatKhau,IdTaiKhoan) values ('" + txtTK.Text + "','" + txtNLMK.Text + "'," + k + ")";
            fn.setData(s1);

        }

        private void loadData(String s)
        {
            DataSet ds = fn.getData(s);
            dtgTaiKhoan.DataSource = ds.Tables[0];
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            String queey = "update TAIKHOAN set MatKhau = '" +txtMK.Text+"' where TaiKhoan = '"+txtNLMK.Text+"'";
            fn.setData(queey);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String s = "select * from TAIKHOAN where TaiKhoan like N'%" + txtsearchten.Text + "%'";
            loadData(s);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            String s = "select *  from TAIKHOAN where TaiKhoan like N'%" + txtsearchten.Text + "%'";
            loadData(s);
        }

        private void dtgTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgTaiKhoan.CurrentRow.Index;
            txtTK.Text = dtgTaiKhoan[0, i].Value.ToString();
            txtMK.Text = dtgTaiKhoan[2,i].Value.ToString();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String sqlz = "delete  TAIKHOAN where TaiKhoan = '"+txtTK.Text+"'" ;
            fn.setData(sqlz);
            MessageBox.Show("thực hiện xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            String s = "select * from TAIKHOAN";
            loadData(s);

        }

        private void UserADTaiKhoanKH_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            query = "select * from TAIKHOAN";
            loadData(query);
        }
    }
}
