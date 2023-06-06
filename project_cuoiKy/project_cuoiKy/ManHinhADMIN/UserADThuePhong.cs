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
    public partial class UserADThuePhong : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dtkt = new DataTable();
        string sql, connstr;
        int i;
        bool flag;
        function fn = new function();
       
     
  
        public UserADThuePhong()
        {
            InitializeComponent();

        }
   
        public void Initialize()
        {

        }
        string strNhan;
   

        private void UserADThuePhong_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT cmnd,hoten,diachi FROM dbo.khachhang";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdkhachhang1.DataSource = dt;
            grdkhachhang1.Refresh();
           dtpngayden.MaxDate = DateTime.Now;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            NapCT();
            flag = true;
        }
        public void NapCT()
        {
            i = grdkhachhang1.CurrentRow.Index;
            txtcmnd.Text = grdkhachhang1[0, i].Value.ToString();
            txtHoTen.Text = grdkhachhang1[1, i].Value.ToString();
            txtDiachi.Text = grdkhachhang1[2, i].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADTimkiem k = new ADTimkiem();
            k.TruyenData = new ADTimkiem.TruyenChoCha(LoadData);
            k.ShowDialog();
            flag = true;
            try
            {

                


             string   sql2 = "select [check],ngaycheckin from PhongDatTruoc1 where idphong =  '" +txtSoPhong.Text+ "' and [check] = 1 ";
                da2 = new SqlDataAdapter(sql2, conn);
                dt1.Clear();
                da2.Fill(dt1);
                string z = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                if(z != "1")
                {
                    z = "5";
                }    
                if (z == "1")
                {

                   
                   
                    DateTime d1 = Convert.ToDateTime(Convert.ToString(dt1.Rows[0].ItemArray[1]));
                    // int k = Convert.ToInt16(d1.Day) - 1;
                    // int z1 = Convert.ToInt16(d1.Month);
                    // int j = Convert.ToInt16(d1.Year);
                    dtpngayden.MaxDate = d1.AddDays(-1);
                }
                if (z == "5")
                {
                    //dtpngayroidi.Value = Convert.ToDateTime(Convert.ToString(dt1.Rows[0].ItemArray[1]));
                    DateTime d1 = Convert.ToDateTime(Convert.ToString(dt1.Rows[0].ItemArray[1]));
                    // txttt.Text = "Không có";
                    dtpngayden.MaxDate = d1.AddDays(+20000000000);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có ngày ngày trong CSDL");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            grdkhachhang1.CurrentCell = grdkhachhang1[0, 0];
            NapCT();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
         
            i = grdkhachhang1.CurrentRow.Index;
            if (i < grdkhachhang1.Rows.Count - 1)
            {
                grdkhachhang1.CurrentCell = grdkhachhang1[0, i + 1];
                NapCT();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            i = grdkhachhang1.CurrentRow.Index;
            if (i != 0)
            {
                grdkhachhang1.CurrentCell = grdkhachhang1[0, i - 1];
                NapCT();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            grdkhachhang1.CurrentCell = grdkhachhang1[0, grdkhachhang1.Rows.Count - 2];
            NapCT();
        }

        private void grdkhachhang1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();  
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flag = true;
            if (txtHoTen.Text != "" && txtSoPhong.Text != "")
            {
                if (flag == true)
                {
                    string gioden =  DateTime.Now.ToString("HH:mm");
                    string ngayden = dtpngayden.Value.ToString("yyyy-MM-dd");
                    sql = "INSERT INTO dbo.hoadonphong( idkh ,idphong,ngaycheckin) VALUES(( SELECT idkh FROM dbo.khachhang WHERE cmnd = '"
                        + txtcmnd.Text + "' ) ,'" + txtSoPhong.Text + "' ,'" + ngayden + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    string sql1 =  "UPDATE dbo.phong SET trangthai = N'Có người' WHERE idphong = '" +txtSoPhong.Text + "'";
                    fn.setData(sql1);
                    
                }
                else
                {
                    string ngayden = dtpngayden.Value.ToString("yyyy-MM-dd");
                    sql = "INSERT INTO dbo.khachhang( cmnd, hoten, diachi )VALUES('" + txtcmnd.Text + "',N'" + txtHoTen.Text + "',N'" + txtDiachi.Text + "') "
                        + "INSERT INTO dbo.hoadonphong( idkh,idphong ,ngaycheckin)"
                        + "VALUES  ( (SELECT idkh FROM dbo.khachhang WHERE cmnd = '" + txtcmnd.Text + "'),'" + txtSoPhong.Text + "' ,'" + ngayden + "')"
                        + "UPDATE dbo.phong SET trangthai = N'Có người' WHERE idphong = '" + txtSoPhong.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = "SELECT cmnd,hoten,diachi FROM dbo.khachhang";
                    da = new SqlDataAdapter(sql, conn);
                    dt.Clear();
                    da.Fill(dt);
                    grdkhachhang1.DataSource = dt;
                    grdkhachhang1.Refresh();
                    grdkhachhang1.CurrentCell = grdkhachhang1[0, grdkhachhang1.RowCount - 2];

                }

                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);

                //Đặt lại dữ liệu cho idphong
              txtSoPhong.Text = "";
                txtcmnd.Text = "";
                txtDiachi.Text = "";
                txtHoTen.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tenkhach;
            if (txttimkiem.Text == "Nhập tên khách hàng") tenkhach = "";
            else tenkhach = txttimkiem.Text;
            sql = "SELECT cmnd,hoten,diachi FROM dbo.khachhang WHERE hoten LIKE N'%" + tenkhach + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdkhachhang1.DataSource = dt;
            grdkhachhang1.Refresh();
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            guna2Button2.Enabled = true;
            if (guna2RadioButton1.Checked == true)
            {
                string sql2 = "select cmnd from khachhang";
                da = new SqlDataAdapter(sql2, conn);
                dt.Clear();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (txtcmnd.Text == Convert.ToString(dt.Rows[i][0]))
                    {
                        MessageBox.Show("Trùng số CMND ");
                        txtcmnd.Text = "0";
                        guna2Button2.Enabled = false;
                        break;

                    }

                }
                guna2RadioButton1.Checked = false;
            }
        }

        private void grdkhachhang1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData(string data)
        {
            txtSoPhong.Text = " ";
            txtSoPhong.Text = data;
        }
    }
}
