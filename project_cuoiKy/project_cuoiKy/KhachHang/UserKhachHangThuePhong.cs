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
    public partial class UserKhachHangThuePhong : UserControl
    {
        function fn = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlCommand cmd;
        DataTable dt1 = new DataTable();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtkt = new DataTable();
        string sql, connstr, sql2;
        int i, songaythue, tt = 1;
        bool flag = false;
        public UserKhachHangThuePhong()
        {
            InitializeComponent();
            //dtpngayden.MaxDate = DateTime.MaxValue;
        }
        public void loadDataPhong(String qur)
        {


            DataSet ds = fn.getData(qur);
            dtgdulieu.DataSource = ds.Tables[0];

        }

        private void dtgdulieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtidphong.Text = dtgdulieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                flag = true;
                

                sql2 = "select [check],ngaycheckin from PhongDatTruoc1 where idphong =  '" + dtgdulieu.Rows[e.RowIndex].Cells[0].Value.ToString() + "' and [check] = 1 ";
                da2 = new SqlDataAdapter(sql2, conn);
                dt1.Clear();
                da2.Fill(dt1);
                string z = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                if( z == "1")
                { 
                   
                    txttt.Text = "Có người";
                    dtpngayroidi.Value = Convert.ToDateTime(Convert.ToString(dt1.Rows[0].ItemArray[1]));
                    DateTime d1 = Convert.ToDateTime(dtpngayroidi.Value.ToString());
                   // int k = Convert.ToInt16(d1.Day) - 1;
                   // int z1 = Convert.ToInt16(d1.Month);
                   // int j = Convert.ToInt16(d1.Year);
                    dtpngayden.MaxDate = d1.AddDays(-1);
                }
               else if ( z == "" || z == " " || z == null)
                {
                    dtpngayroidi.Value = Convert.ToDateTime(Convert.ToString(dt1.Rows[0].ItemArray[1]));
                    DateTime d1 = Convert.ToDateTime(dtpngayroidi.Value.ToString());
                    txttt.Text = "Không có";
                    dtpngayden.MaxDate = d1.AddYears(+100);
                }    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có ngày ngày trong CSDL");
            }
        }

        private void dtgdulieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            flag = true;
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            flag = true;
            dtpngayden.Value = DateTime.Now;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string z = "1";
            if (flag == true)
            {

                if (txtidphong.Text != "")
                {
                    string ngayhientai = DateTime.Now.ToString("yyyy-MM-dd");
                    DateTime d1 = Convert.ToDateTime(ngayhientai.ToString());
                    
                    string ngayden = dtpngayden.Value.ToString("yyyy-MM-dd");
                    string ngayroidi = dtpngayroidi.Value.ToString("yyyy-MM-dd");
                    DateTime d2 = Convert.ToDateTime(ngayden.ToString());
                    DateTime d3 = Convert.ToDateTime(ngayden.ToString());
                   
                    int ngayden2 = Convert.ToInt16(d2.Day.ToString());
                   
                
                    int ngaycheckout = ngayden2 + songaythue;

                    string ngay = Convert.ToString(ngaycheckout);
                    
                  
                    if (d1.Month == d2.Month)
                    {
                       
                        if (d1.Day == d2.Day)
                        {
                          
                            String    sql1 = "INSERT INTO dbo.hoadonphong( idkh ,idphong,ngaycheckin)VALUES(( SELECT idkh FROM dbo.khachhang WHERE cmnd = '"
                                                                 + txtcmnd.Text + "' ) ,'" + txtidphong.Text + "' ,'" + ngayden + "')"
                                                                 + "UPDATE dbo.phong SET trangthai = N'Có người' WHERE idphong = '" + txtidphong.Text + "'";
                               // cmd = new SqlCommand(sql1, conn);
                               // cmd.ExecuteNonQuery();
                                fn.setData(sql1);
                                string sqlphong = "SELECT * FROM dbo.phong WHERE trangthai = N'Trống' or trangthai =N' đặt trước'";
                                loadDataPhong(sqlphong);
                                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }    
                        
                        
                      else  if (d1.Day < d2.Day)
                        {
                            String sql3 = " insert into PhongDatTruoc1(idkh,idphong,trangthai,ngaycheckin,[check]) values (( SELECT idkh FROM dbo.khachhang WHERE cmnd = '"
                                         + txtcmnd.Text + "' ),'" + txtidphong.Text + "',N'đặt trước','" + ngayden + "' ," +Convert.ToInt16(z.ToString())+ ") ";
                            fn.setData(sql3);
                            MessageBox.Show("Đăng ký giữ phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("bạn không thể đăng kí phòng này","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }    
                    }  
                    else if(d1.Month < d2.Month)
                    {
                       
                        String sql1 = " insert into PhongDatTruoc1(idkh,idphong,trangthai,ngaycheckin,check) values (( SELECT idkh FROM dbo.khachhang WHERE cmnd = '"
                                        + txtcmnd.Text + "' ),'" + txtidphong.Text + "',N' đặt trước','" + ngayden + "','"+tt+"')";
                        fn.setData(sql1);
                        MessageBox.Show("Đăng ký giữ phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
        
                }
            }    
           
        }

        private void btnThuetheogio_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void btnthuetheongay_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void txtsongay_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserKhachHangThuePhong_Load(object sender, EventArgs e)
        {
            try
            {
                
                string sqlphong = "SELECT * FROM dbo.phong WHERE trangthai = N'Trống' or trangthai =N' đặt trước'";
                connstr = Bientoancuc.TCconnstr;
                conn.ConnectionString = connstr;
                conn.Open();
                loadDataPhong(sqlphong);
                //loadData(sqlkhachhang);

                //  grdPhong[1, 2].Value.ToString() = "NONE";
                // grdPhong.Rows[0].Cells[2].Value.ToString() = "NONE";
                sql = "SELECT cmnd,hoten,diachi,idkh FROM dbo.khachhang where khachhang.idkh = " + int.Parse(Bientoancuc.saveIDKH) + "";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                txthoten.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                txtcmnd.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
                txtdiachi.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                txthoten.Enabled = false;
                txtcmnd.Enabled = false;
                txtdiachi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
