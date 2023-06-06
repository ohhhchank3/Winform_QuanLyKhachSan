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
    public partial class UserThuePhongOnline : UserControl
    {
        SqlConnection conn = new SqlConnection();
        //  SqlDataAdapter da = new SqlDataAdapter();
        string sql, sql1, sql2, connstr;

        private void btnxemrieng_Click(object sender, EventArgs e)
        {
            conn.Close();
            if (btnxemtheothang.Checked == true)
            {
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chart1.Series["Giá trị"].XValueMember = "Thang";
                chart1.Series["Giá trị"].YValueMembers = "Tong";
                chart1.ChartAreas[0].AxisX.Maximum = 31;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 2;
                chart1.ChartAreas[0].AxisY.Maximum = 30;
                sql = "";
                // dt.Clear();
                btnxemtheothang.Checked = false;
                //   dt.Clear();
                conn.Close();
                lbten.Text = "Tháng :";
                label5.Text = " Mức tăng trưởng so với tháng trước :";
                lbthang.Text = cmbthang.SelectedItem.ToString();
                string query = "select count(idphong) from PhongDatTruoc1 where month(ngaycheckin) = " + int.Parse(lbthang.Text) + "";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                txtTongSoLuong.Text = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                float k = float.Parse(Convert.ToString(dt1.Rows[0].ItemArray[0]));
                float z = k / 250;
                txthieusuat.Text = Convert.ToString(z) + "%";
                int a112 = int.Parse(lbthang.Text) - 1;
                string query1 = "select count(idphong) from PhongDatTruoc1 where month(ngaycheckin) = " + a112 + "";
                SqlDataAdapter ad2 = new SqlDataAdapter(query1, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                string z1 = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                if (z1 == "")
                {
                    z1 = "0";
                }
                if (z1 == "0")
                {
                    txtsosanh.Text = "100%";
                }
                else
                {
                    float z11 = float.Parse(z1);
                    float sosanh = k / z11;
                    txtsosanh.Text = Convert.ToString(sosanh) + "%";
                }



            }
            if (btnxemtheonam.Checked == true)
            {
                conn.Open();
                SqlDataAdapter ad3 = new SqlDataAdapter(sql1, conn);
                DataTable dt123 = new DataTable();
                ad3.Fill(dt123);
                chart1.DataSource = dt123;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chart1.Series["Giá trị"].XValueMember = "Thang1";
                chart1.Series["Giá trị"].YValueMembers = "Tong1";
                chart1.ChartAreas[0].AxisX.Minimum = 1;
                // string day = DateTime.Now.ToString("yyyy-MM-dd");
                // DateTime d2 = Convert.ToDateTime()
                chart1.ChartAreas[0].AxisX.Maximum = 12;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 30;
                chart1.ChartAreas[0].AxisY.Maximum = 400;
                sql1 = "";
                // dt.Clear();
                label5.Text = " Mức tăng trưởng so với năm trước :";
                lbten.Text = "Năm :";
                lbthang.Text = cmbnam.SelectedItem.ToString();

                btnxemtheonam.Checked = false;
                // xử lý 
                lbthang.Text = cmbnam.SelectedItem.ToString();
                string query = "select count(idphong) from PhongDatTruoc1 where year(ngaycheckin) = " + int.Parse(lbthang.Text) + "";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                txtTongSoLuong.Text = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                float k = float.Parse(Convert.ToString(dt1.Rows[0].ItemArray[0]));
                float z = k / 250;
                txthieusuat.Text = Convert.ToString(z) + "%";
                int a112 = int.Parse(lbthang.Text) - 1;
                string query1 = "select count(idphong) from PhongDatTruoc1 where year(ngaycheckin) = " + a112 + "";
                SqlDataAdapter ad2 = new SqlDataAdapter(query1, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                string z1 = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                if (z1 == "")
                {
                    z1 = "0";
                }
                if (z1 == "0")
                {
                    txtsosanh.Text = "100%";
                }
                else
                {
                    float z11 = float.Parse(z1);
                    float sosanh = k / z11;
                    txtsosanh.Text = Convert.ToString(sosanh) + "%";
                }

                conn.Close();
                //  dt1.Clear();
            }
            if (btnchonca2.Checked == true && btnxemtheonam.Checked == false && btnxemtheothang.Checked == false)
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
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                chart1.Series["Giá trị"].XValueMember = "Thang";
                chart1.Series["Giá trị"].YValueMembers = "Tong";
                chart1.ChartAreas[0].AxisY.Maximum = 20000000;
                chart1.ChartAreas[0].AxisX.Maximum = 31;
                sql2 = "";
                //  btnchonca2.Checked = false;
                //  /

            }
        }

        private void btnxemtheonam_CheckedChanged(object sender, EventArgs e)
        {
            sql1 = "select count(idphong) as Tong1 ,Month(ngaycheckin) as Thang1 from PhongDatTruoc1 where Year(ngaycheckin) = " + int.Parse(cmbnam.SelectedItem.ToString()) + " group by Month(Ngaycheckin) ";
        }

        private void cmbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnxemtheonam.Enabled = true;
        }

        private void btnlen_Click(object sender, EventArgs e)
        {
            if (lbthang.Text != "")
            {
                int tinhtoan = int.Parse(lbthang.Text) - 1;
                string sql22 = "select count(idphong) as Tong ,day(ngaycheckin) as Thang from PhongDatTruoc1 where month(ngaycheckin) = " + tinhtoan + " group by day(Ngaycheckin)";
                SqlDataAdapter ad4 = new SqlDataAdapter(sql22, conn);
                DataTable dt4 = new DataTable();
                ad4.Fill(dt4);
                chart1.DataSource = dt4;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chart1.Series["Giá trị"].XValueMember = "Thang";
                chart1.Series["Giá trị"].YValueMembers = "Tong";
                chart1.ChartAreas[0].AxisX.Maximum = 31;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 2;
                chart1.ChartAreas[0].AxisY.Maximum = 30;
                sql22 = "";
                // dt.Clear();
                btnxemtheothang.Checked = false;
                //   dt.Clear();
                conn.Close();
                lbten.Text = "Tháng :";
                label5.Text = " Mức tăng trưởng so với tháng trước :";
                lbthang.Text = Convert.ToString(tinhtoan);
                string query = "select count(idphong) from PhongDatTruoc1 where month(ngaycheckin) = " + int.Parse(lbthang.Text) + "";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                txtTongSoLuong.Text = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                float k = float.Parse(Convert.ToString(dt1.Rows[0].ItemArray[0]));
                float z = k / 250;
                txthieusuat.Text = Convert.ToString(z) + "%";
                int a112 = int.Parse(lbthang.Text) - 1;
                string query1 = "select count(idphong) from PhongDatTruoc1 where month(ngaycheckin) = " + a112 + "";
                SqlDataAdapter ad2 = new SqlDataAdapter(query1, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                string z1 = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                if (z1 == "")
                {
                    z1 = "0";
                }
                if (z1 == "0")
                {
                    txtsosanh.Text = "100%";
                }
                else
                {
                    float z11 = float.Parse(z1);
                    float sosanh = k / z11;
                    txtsosanh.Text = Convert.ToString(sosanh) + "%";
                }
                int chisomuc = int.Parse(cmbthang.SelectedItem.ToString()) - 1;
                cmbthang.Text = Convert.ToString(chisomuc);

            }
        }

        private void btnxuong_Click(object sender, EventArgs e)
        {
            if (lbthang.Text != "")
            {
                int tinhtoan = int.Parse(lbthang.Text) + 1;
                string sql22 = "select count(idphong) as Tong ,day(ngaycheckin) as Thang from PhongDatTruoc1 where month(ngaycheckin) = " + tinhtoan + " group by day(Ngaycheckin)";
                SqlDataAdapter ad4 = new SqlDataAdapter(sql22, conn);
                DataTable dt4 = new DataTable();
                ad4.Fill(dt4);
                chart1.DataSource = dt4;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chart1.Series["Giá trị"].XValueMember = "Thang";
                chart1.Series["Giá trị"].YValueMembers = "Tong";
                chart1.ChartAreas[0].AxisX.Maximum = 31;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Interval = 2;
                chart1.ChartAreas[0].AxisY.Maximum = 30;
                sql22 = "";
                // dt.Clear();
                btnxemtheothang.Checked = false;
                //   dt.Clear();
                conn.Close();
                lbten.Text = "Tháng :";
                label5.Text = " Mức tăng trưởng so với tháng trước :";
                lbthang.Text = Convert.ToString(tinhtoan);
                string query = "select count(idphong) from PhongDatTruoc1 where month(ngaycheckin) = " + int.Parse(lbthang.Text) + "";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                txtTongSoLuong.Text = Convert.ToString(dt1.Rows[0].ItemArray[0]);
                float k = float.Parse(Convert.ToString(dt1.Rows[0].ItemArray[0]));
                float z = k / 250;
                txthieusuat.Text = Convert.ToString(z) + "%";
                int a112 = int.Parse(lbthang.Text) - 1;
                string query1 = "select count(idphong) from PhongDatTruoc1 where month(ngaycheckin) = " + a112 + "";
                SqlDataAdapter ad2 = new SqlDataAdapter(query1, conn);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                string z1 = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                if (z1 == "")
                {
                    z1 = "0";
                }
                if (z1 == "0")
                {
                    txtsosanh.Text = "100%";
                }
                else
                {
                    float z11 = float.Parse(z1);
                    float sosanh = k / z11;
                    txtsosanh.Text = Convert.ToString(sosanh) + "%";
                }
                int chisomuc = int.Parse(cmbthang.SelectedItem.ToString()) + 1;
                cmbthang.Text = Convert.ToString(chisomuc);



                //cmbthang.DataSource = thang;
            }
        }

        private void cmbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnxemtheothang.Enabled = true;
        }

        private void btnxemtheothang_CheckedChanged(object sender, EventArgs e)
        {
            sql = "select count(idphong) as Tong ,day(ngaycheckin) as Thang from PhongDatTruoc1 where month(ngaycheckin) = " + int.Parse(cmbthang.SelectedItem.ToString()) + " group by day(ngaycheckin)";
        }
    

        public UserThuePhongOnline()
        {
            InitializeComponent();
        }

        private void UserThuePhongOnline_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            btnxemtheonam.Enabled = false;
            btnxemtheothang.Enabled = false;
            btnchonca2.Enabled = false;
        }
    }
}
