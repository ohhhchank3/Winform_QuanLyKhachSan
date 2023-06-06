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
    public partial class ThongKeDoanhThu : Form
    {
        SqlConnection conn = new SqlConnection();
        //  SqlDataAdapter da = new SqlDataAdapter();
        string sql, sql1, sql2, connstr;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
        }

        private void btnxemrieng_Click(object sender, EventArgs e)
        {
            conn.Close();
            if (btnxemtheothang.Checked == true )
            {
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(sql1, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng tiền1";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày1";
                chart1.Series["Series1"].XValueMember = "Thang3";
                chart1.Series["Series1"].YValueMembers = "Tong3";
                chart1.ChartAreas[0].AxisX.Maximum = 31;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 500000;
                chart1.ChartAreas[0].AxisY.Maximum = 10000000;
                sql1 = "";
               // dt.Clear();
            // btnxemtheothang.Checked = false;
                //   dt.Clear();
                conn.Close();
              
            }
   if( btnxemthang.Checked == true )
            {
                conn.Open();
                SqlDataAdapter ad1 = new SqlDataAdapter(sql, conn);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                chart1.DataSource = dt1;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng tiền";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                chart1.Series["Series1"].XValueMember = "Thang2";
                chart1.Series["Series1"].YValueMembers = "Tong2";
                chart1.ChartAreas[0].AxisX.Minimum = 2020;
               // string day = DateTime.Now.ToString("yyyy-MM-dd");
                // DateTime d2 = Convert.ToDateTime()
               chart1.ChartAreas[0].AxisX.Maximum = 2035;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 5000000;
                chart1.ChartAreas[0].AxisY.Maximum = 100000000;
                // dt.Clear();
                sql = "";
            btnxemthang.Checked = false;
                conn.Close();
              //  dt1.Clear();
            }
 if (btnchonca2.Checked == true && btnxemthang.Checked == false  && btnxemtheothang.Checked == false)
            {
               // chart1.Series.Clear();
              //  SqlConnection con2 = new SqlConnection(@"Data Source=VONHUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
       
                SqlDataAdapter ad2 = new SqlDataAdapter(sql2, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                chart1.DataSource = dt2;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 500000;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng tiền";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chart1.Series["Series1"].XValueMember = "Thang2";
                chart1.Series["Series1"].YValueMembers = "Tong1";
                chart1.ChartAreas[0].AxisY.Maximum = 20000000;
                chart1.ChartAreas[0].AxisX.Maximum = 31;
                sql2 = "";
           //  btnchonca2.Checked = false;
           //  /
              
            }

            //chart1.Series.Clear();
        }

        private void btnxemthang_CheckedChanged(object sender, EventArgs e)
        {
           if(btnxemthang.Checked == true)
            {
                sql = "select sum(tongtien) as Tong2 ,Year(ngaycheckout) as Thang2 from HoaDonPhong where Year(ngaycheckout) = " + int.Parse(cmbnam.SelectedItem.ToString()) + " group by Year(Ngaycheckout)  ";
            }    
           
        }

        private void btnlen_Click(object sender, EventArgs e)
        {

        }

        private void btnxuong_Click(object sender, EventArgs e)
        {

        }

        private void btnxemtheonam_CheckedChanged(object sender, EventArgs e)
        {
            if(btnxemtheothang.Checked == true )
            {
                try
                {
                    if (cmbthang.SelectedItem.ToString() != "")
                    {
                        sql1 = "select sum(tongtien) as Tong3 ,day(ngaycheckout) as Thang3 from HoaDonPhong where month(ngaycheckout) = " + int.Parse(cmbthang.SelectedItem.ToString()) + " group by day(Ngaycheckout)  ";
                    }
                    else
                    {
                        MessageBox.Show("vui lòng điền tháng!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng điền tháng ");
                }
            }    
          
         
        }

        private void btnxemca2_Click(object sender, EventArgs e)
        {

         
        }

        private void btnchonca2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbthang.SelectedItem.ToString() != "" && cmbnam.SelectedItem.ToString() != "")
                {
                    sql2 = "select sum(tongtien) as Tong1 ,day(ngaycheckout) as Thang2 from HoaDonPhong where month(ngaycheckout) = " + int.Parse(cmbthang.SelectedItem.ToString()) +  "  and year(ngaycheckout) = "+int.Parse(cmbnam.SelectedItem.ToString())+" group by day(Ngaycheckout)  ";
                }
                else
                {
                    MessageBox.Show("vui lòng điền tháng!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền tháng ");
            }
        }
    }
}
