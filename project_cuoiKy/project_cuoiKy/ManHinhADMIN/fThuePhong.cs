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
    public partial class fThuePhong : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dtkt = new DataTable();
        string sql,sql11,sql2, connstr;
        int i;
        bool flag; // cờ kiểm tra xem khách mới hay cũ
        public fThuePhong()
        {
            InitializeComponent();
        }
        string strNhan;
        public fThuePhong(string giatrinhan) : this()
        {
            txtSoPhong.Text = giatrinhan;

        }
        private void fThuePhong_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT cmnd,hoten,diachi FROM dbo.khachhang";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdkhachhang1.DataSource = dt;
            grdkhachhang1.Refresh();
            txtSoPhong.Enabled = false;
        }

        private void grdkhachhang1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             NapCT();
            flag = true;
           
        }

        private void grdkhachhang1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
            flag = true;
            try
            {




                string sql3 = "select [check],ngaycheckin from PhongDatTruoc1 where idphong =  '" + txtSoPhong.Text + "' and [check] = 1 ";
                da2 = new SqlDataAdapter(sql3, conn);
                dt1.Clear();
                da2.Fill(dt1);
                string z = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                if (z != "1")
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flag = true;
            if (txtHoTen.Text != "" && txtSoPhong.Text != "")
            {
                if (flag == true )
                {
                    string ngayden = dtpngayden.Value.ToString("yyyy-MM-dd");
                    sql11 = "INSERT INTO dbo.hoadonphong( idkh ,idphong,ngaycheckin)VALUES(( SELECT idkh FROM dbo.khachhang WHERE cmnd = '"
                        + txtcmnd.Text + "' ) ,'" + txtSoPhong.Text + "' ,'" + ngayden + "')"
                        + "UPDATE dbo.phong SET trangthai = N'Có người' WHERE idphong = '" + txtSoPhong.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
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

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btntiemkiem_Click(object sender, EventArgs e)
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

        public void NapCT()
        {
            try
            {
                i = grdkhachhang1.CurrentRow.Index;
                txtcmnd.Text = grdkhachhang1[0, i].Value.ToString();
                txtHoTen.Text = grdkhachhang1[1, i].Value.ToString();
                txtDiachi.Text = grdkhachhang1[2, i].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
