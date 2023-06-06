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
    public partial class FRDangKY : Form
    {
        public FRDangKY()
        {
            InitializeComponent();
        }
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
      
        Random rnd = new Random();

        private void Check(int stt)
        {
            string s = "select IdTaiKhoan from TAIKHOAN ";

            da = new SqlDataAdapter(s, conn);
            dt.Clear();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (stt == (Convert.ToInt16(dt.Rows[i][0])))
                {
                    stt = rnd.Next(400, 20000);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(cbcheck.Checked == true )
            {
                int k = rnd.Next(100, 2000);
                Check(k);

                string sql1 = "SET IDENTITY_INSERT dbo.khachhang on ;" +
                    "insert into khachhang(idkh,cmnd,hoten) values (" + k + ",'"+txtcmnd.Text+"','"+txtHoTen.Text+"')";
                cmd = new SqlCommand(sql1, conn);
                cmd.ExecuteNonQuery();
             if(txtMK.Text.ToString() == txtNLMK.Text.ToString())
              {
                    String s1 = "insert into TAIKHOAN(TaiKhoan,MatKhau,IdTaiKhoan) values ('" + txtTK.Text + "','" + txtNLMK.Text + "'," + k + ")";
                    fn.setData(s1);
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
              
               
            }
            else
            {
                MessageBox.Show("Cần tích vào đồng ý điều khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }    
        }
        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //guna2Button1.Enabled = true;
            if(guna2RadioButton1.Checked == true)
            {
                string sql2 = "select cmnd from khachhang";
                da = new SqlDataAdapter(sql2, conn);
                dt.Clear();
                da.Fill(dt);
                for(int i =0; i<dt.Rows.Count;i++)
                {
                    if(txtcmnd.Text == Convert.ToString(dt.Rows[i][0]))
                    {
                        MessageBox.Show("Trùng số CMND ");
                        txtcmnd.Text = "0";
                      //  guna2Button1.Enabled = false;
                        break;
                       
                    }

                }
               // guna2RadioButton1.Checked = false;
            }    
        }

        private void FRDangKY_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
          //  guna2Button1.Enabled = false;
        }
    }
}
