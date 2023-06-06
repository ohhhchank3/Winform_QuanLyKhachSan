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
    public partial class UserKHThongTin123 : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtdv = new DataTable();
        DataTable dtrpt = new DataTable();
        string sql, connstr;
        int tt, ttdv;
        int giaphong;
        int tienphong;
        function fn = new function();
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        public void LoadThongTin()
        {
            try
            {
                sql = "select hoten,cmnd,diachi from khachhang where khachhang.idkh = " + int.Parse(Bientoancuc.saveIDKH) + "";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                txtHoTen.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
                txtCMND.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                txtDiaChi.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {

            try
            {
                String query1 = "select khachhang.hoten,khachhang.cmnd,khachhang.diachi from khachhang where idkh = " + int.Parse(txtId.Text) + "";
                loadData(query1);
                LoadThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bientoancuc.SaveEnglish == 1)
                {
                    String queeytwo = "update khachhang set hoten = N'" + txtHoTen.Text + "',cmnd = '" + txtCMND.Text + "',diachi = N'" + txtDiaChi.Text + "'" +
                   "where idkh = " + int.Parse(txtId.Text) + "";
                    MessageBox.Show("Successfully updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn.setData(queeytwo);
                    LoadThongTin();

                }
                else
                {
                    String queeytwo = "update khachhang set hoten = N'" + txtHoTen.Text + "',cmnd = '" + txtCMND.Text + "',diachi = N'" + txtDiaChi.Text + "'" +
                   "where idkh = " + int.Parse(txtId.Text) + "";
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fn.setData(queeytwo);
                    LoadThongTin();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        public UserKHThongTin123()
        {
            InitializeComponent();
        }

        public void UserKHThongTin123_Load(object sender, EventArgs e)
        {
         
          
         
            txtId.Text = Bientoancuc.saveIDKH;
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            LoadThongTin();
        }
    }
}
