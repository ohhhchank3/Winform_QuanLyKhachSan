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
    public partial class UserADManhinhchinh : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dttenv = new DataTable();
        DataTable dtrpt = new DataTable();
        string sql, connstr, sql1;
        string user;
        function fn = new function();
        public UserADManhinhchinh()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 0].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
              FrThanhToan f = new FrThanhToan(grdAN[0, 0].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            } 
                
        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(btn2.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 1].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 1].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(btn3.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 2].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 2].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 3].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 3].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 4].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 4].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 5].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 5].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 6].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 6].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 7].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 7].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 8].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 8].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 9].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 9].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 10].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 10].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 11].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 11].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (btn13.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 12].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 12].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (btn14.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 13].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 13].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (btn15.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 14].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 14].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (btn16.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 15].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 15].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (btn17.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 16].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 16].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (btn18.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 17].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 17].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (btn19.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 18].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 18].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (btn20.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 19].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 19].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (btn21.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 20].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 20].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (btn22.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 21].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 21].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (btn23.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 22].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 22].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (btn24.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 23].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 23].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (btn25.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 24].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 24].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (btn26.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 25].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 25].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            if (btn27.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 26].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 26].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            if (btn28.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 27].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 27].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            if (btn29.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 28].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 28].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            if (btn30.BackColor == Color.LimeGreen)
            {
                fThuePhong f = new fThuePhong(grdAN[0, 29].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
            else
            {
                FrThanhToan f = new FrThanhToan(grdAN[0, 29].Value.ToString());
                f.ShowDialog();
                sql = "Select idphong,loaiphong,trangthai from dbo.phong";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdAN.DataSource = dt;
                grdAN.Refresh();
                NapCT();
            }
        }

        private void UserADManhinhchinh_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "Select idphong,loaiphong,trangthai from dbo.phong";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdAN.DataSource = dt;
            grdAN.Refresh();
            NapCT();
        }
        private void NapCT()
        {

            lb1.Text = grdAN[0, 0].Value.ToString() + " " + grdAN[1, 0].Value.ToString();
            lb2.Text = grdAN[0, 1].Value.ToString() + " " + grdAN[1, 1].Value.ToString();
            lb3.Text = grdAN[0, 2].Value.ToString() + " " + grdAN[1, 2].Value.ToString();
            lb4.Text = grdAN[0, 3].Value.ToString() + " " + grdAN[1, 3].Value.ToString();
            lb5.Text = grdAN[0, 4].Value.ToString() + " " + grdAN[1, 4].Value.ToString();
            lb6.Text = grdAN[0, 5].Value.ToString() + " " + grdAN[1, 5].Value.ToString();
            lb7.Text = grdAN[0, 6].Value.ToString() + " " + grdAN[1, 6].Value.ToString();
            lb8.Text = grdAN[0, 7].Value.ToString() + " " + grdAN[1, 7].Value.ToString();
            lb9.Text = grdAN[0, 8].Value.ToString() + " " + grdAN[1, 8].Value.ToString();
            lb10.Text = grdAN[0, 9].Value.ToString() + " " + grdAN[1, 9].Value.ToString();
            lb11.Text = grdAN[0, 10].Value.ToString() + " " + grdAN[1, 10].Value.ToString();
            lb12.Text = grdAN[0, 11].Value.ToString() + " " + grdAN[1, 11].Value.ToString();
            lb13.Text = grdAN[0, 12].Value.ToString() + " " + grdAN[1, 12].Value.ToString();
            lb14.Text = grdAN[0, 13].Value.ToString() + " " + grdAN[1, 13].Value.ToString();
            lb15.Text = grdAN[0, 14].Value.ToString() + " " + grdAN[1, 14].Value.ToString();
            lb16.Text = grdAN[0, 15].Value.ToString() + " " + grdAN[1, 15].Value.ToString();
            lb17.Text = grdAN[0, 16].Value.ToString() + " " + grdAN[1, 16].Value.ToString();
            lb18.Text = grdAN[0, 17].Value.ToString() + " " + grdAN[1, 17].Value.ToString();
            lb19.Text = grdAN[0, 18].Value.ToString() + " " + grdAN[1, 18].Value.ToString();
            lb20.Text = grdAN[0, 19].Value.ToString() + " " + grdAN[1, 19].Value.ToString();
            lb21.Text = grdAN[0, 20].Value.ToString() + " " + grdAN[1, 20].Value.ToString();
            lb22.Text = grdAN[0, 21].Value.ToString() + " " + grdAN[1, 21].Value.ToString();
            lb23.Text = grdAN[0, 22].Value.ToString() + " " + grdAN[1, 22].Value.ToString();
            lb24.Text = grdAN[0, 23].Value.ToString() + " " + grdAN[1, 23].Value.ToString();
            lb25.Text = grdAN[0, 24].Value.ToString() + " " + grdAN[1, 24].Value.ToString();
            lb26.Text = grdAN[0, 25].Value.ToString() + " " + grdAN[1, 25].Value.ToString();
            lb27.Text = grdAN[0, 26].Value.ToString() + " " + grdAN[1, 26].Value.ToString();
            lb28.Text = grdAN[0, 27].Value.ToString() + " " + grdAN[1, 27].Value.ToString();
            lb29.Text = grdAN[0, 28].Value.ToString() + " " + grdAN[1, 28].Value.ToString();
            lb30.Text = grdAN[0, 29].Value.ToString() + " " + grdAN[1, 29].Value.ToString();

            if (grdAN[2, 0].Value.ToString() == "Trống") { btn1.BackColor = Color.LimeGreen; btn1.Enabled = true; } else if (grdAN[2, 0].Value.ToString() == " đặt trước ") { btn1.BackColor = Color.Yellow; btn1.Enabled = true; } else { btn1.BackColor = Color.Red; btn1.Enabled = true; }
            if (grdAN[2, 1].Value.ToString() == "Trống") { btn2.BackColor = Color.LimeGreen; btn2.Enabled = true; } else if (grdAN[2, 1].Value.ToString() == " đặt trước ") { btn2.BackColor = Color.Yellow; btn2.Enabled = true; } else { btn2.BackColor = Color.Red; btn2.Enabled = true; }
            if (grdAN[2, 2].Value.ToString() == "Trống") { btn3.BackColor = Color.LimeGreen; btn3.Enabled = true; } else if (grdAN[2, 2].Value.ToString() == " đặt trước ") { btn3.BackColor = Color.Yellow; btn3.Enabled = true; } else { btn3.BackColor = Color.Red; btn3.Enabled = true; }
            if (grdAN[2, 3].Value.ToString() == "Trống") { btn4.BackColor = Color.LimeGreen; btn4.Enabled = true; } else if (grdAN[2, 3].Value.ToString() == " đặt trước ") { btn4.BackColor = Color.Yellow; btn4.Enabled = true; } else { btn4.BackColor = Color.Red; btn4.Enabled = true; }
            if (grdAN[2, 4].Value.ToString() == "Trống") { btn5.BackColor = Color.LimeGreen; btn5.Enabled = true; } else if (grdAN[2, 4].Value.ToString() == " đặt trước ") { btn5.BackColor = Color.Yellow; btn5.Enabled = true; } else { btn5.BackColor = Color.Red; btn5.Enabled = true; }
            if (grdAN[2, 5].Value.ToString() == "Trống") { btn6.BackColor = Color.LimeGreen; btn6.Enabled = true; } else if (grdAN[2, 5].Value.ToString() == " đặt trước ") { btn6.BackColor = Color.Yellow; btn6.Enabled = true; } else { btn6.BackColor = Color.Red; btn6.Enabled = true; }
            if (grdAN[2, 6].Value.ToString() == "Trống") { btn7.BackColor = Color.LimeGreen; btn7.Enabled = true; } else if (grdAN[2, 6].Value.ToString() == " đặt trước ") { btn7.BackColor = Color.Yellow; btn7.Enabled = true; } else { btn7.BackColor = Color.Red; btn7.Enabled = true; }
            if (grdAN[2, 7].Value.ToString() == "Trống") { btn8.BackColor = Color.LimeGreen; btn8.Enabled = true; } else if (grdAN[2, 7].Value.ToString() == " đặt trước ") { btn8.BackColor = Color.Yellow; btn8.Enabled = true; } else { btn8.BackColor = Color.Red; btn8.Enabled = true; }
            if (grdAN[2, 8].Value.ToString() == "Trống") { btn9.BackColor = Color.LimeGreen; btn9.Enabled = true; } else if (grdAN[2, 8].Value.ToString() == " đặt trước ") { btn9.BackColor = Color.Yellow; btn9.Enabled = true; } else { btn9.BackColor = Color.Red; btn9.Enabled = true; }
            if (grdAN[2, 9].Value.ToString() == "Trống") { btn10.BackColor = Color.LimeGreen; btn10.Enabled = true; } else if (grdAN[2, 9].Value.ToString() == " đặt trước ") { btn10.BackColor = Color.Yellow; btn10.Enabled = true; } else { btn10.BackColor = Color.Red; btn10.Enabled = true; }
            if (grdAN[2, 10].Value.ToString() == "Trống") { btn11.BackColor = Color.LimeGreen; btn11.Enabled = true; } else if (grdAN[2, 10].Value.ToString() == " đặt trước ") { btn11.BackColor = Color.Yellow; btn11.Enabled = true; } else { btn11.BackColor = Color.Red; btn11.Enabled = true; }
            if (grdAN[2, 11].Value.ToString() == "Trống") { btn12.BackColor = Color.LimeGreen; btn12.Enabled = true; } else if (grdAN[2, 11].Value.ToString() == " đặt trước ") { btn12.BackColor = Color.Yellow; btn12.Enabled = true; } else { btn12.BackColor = Color.Red; btn12.Enabled = true; }
            if (grdAN[2, 12].Value.ToString() == "Trống") { btn13.BackColor = Color.LimeGreen; btn13.Enabled = true; } else if (grdAN[2, 12].Value.ToString() == " đặt trước ") { btn13.BackColor = Color.Yellow; btn13.Enabled = true; } else { btn13.BackColor = Color.Red; btn13.Enabled = true; }
            if (grdAN[2, 13].Value.ToString() == "Trống") { btn14.BackColor = Color.LimeGreen; btn14.Enabled = true; } else if (grdAN[2, 13].Value.ToString() == " đặt trước ") { btn14.BackColor = Color.Yellow; btn14.Enabled = true; } else { btn14.BackColor = Color.Red; btn14.Enabled = true; }
            if (grdAN[2, 14].Value.ToString() == "Trống") { btn15.BackColor = Color.LimeGreen; btn15.Enabled = true; } else if (grdAN[2, 14].Value.ToString() == " đặt trước ") { btn15.BackColor = Color.Yellow; btn15.Enabled = true; } else { btn15.BackColor = Color.Red; btn15.Enabled = true; }
            if (grdAN[2, 15].Value.ToString() == "Trống") { btn16.BackColor = Color.LimeGreen; btn16.Enabled = true; } else if (grdAN[2, 15].Value.ToString() == " đặt trước ") { btn16.BackColor = Color.Yellow; btn16.Enabled = true; } else { btn16.BackColor = Color.Red; btn16.Enabled = true; }
            if (grdAN[2, 16].Value.ToString() == "Trống") { btn17.BackColor = Color.LimeGreen; btn17.Enabled = true; } else if (grdAN[2, 16].Value.ToString() == " đặt trước ") { btn17.BackColor = Color.Yellow; btn17.Enabled = true; } else { btn17.BackColor = Color.Red; btn17.Enabled = true; }
            if (grdAN[2, 17].Value.ToString() == "Trống") { btn18.BackColor = Color.LimeGreen; btn18.Enabled = true; } else if (grdAN[2, 17].Value.ToString() == " đặt trước ") { btn18.BackColor = Color.Yellow; btn18.Enabled = true; } else { btn18.BackColor = Color.Red; btn18.Enabled = true; }
            if (grdAN[2, 18].Value.ToString() == "Trống") { btn19.BackColor = Color.LimeGreen; btn19.Enabled = true; } else if (grdAN[2, 18].Value.ToString() == " đặt trước ") { btn19.BackColor = Color.Yellow; btn19.Enabled = true; } else { btn19.BackColor = Color.Red; btn19.Enabled = true; }
            if (grdAN[2, 19].Value.ToString() == "Trống") { btn20.BackColor = Color.LimeGreen; btn20.Enabled = true; } else if (grdAN[2, 19].Value.ToString() == " đặt trước ") { btn20.BackColor = Color.Yellow; btn20.Enabled = true; } else { btn20.BackColor = Color.Red; btn20.Enabled = true; }
            if (grdAN[2, 20].Value.ToString() == "Trống") { btn21.BackColor = Color.LimeGreen; btn21.Enabled = true; } else if (grdAN[2, 20].Value.ToString() == " đặt trước ") { btn21.BackColor = Color.Yellow; btn21.Enabled = true; } else { btn21.BackColor = Color.Red; btn21.Enabled = true; }
            if (grdAN[2, 21].Value.ToString() == "Trống") { btn22.BackColor = Color.LimeGreen; btn22.Enabled = true; } else if (grdAN[2, 21].Value.ToString() == " đặt trước ") { btn22.BackColor = Color.Yellow; btn22.Enabled = true; } else { btn22.BackColor = Color.Red; btn22.Enabled = true; }
            if (grdAN[2, 22].Value.ToString() == "Trống") { btn23.BackColor = Color.LimeGreen; btn23.Enabled = true; } else if (grdAN[2, 22].Value.ToString() == " đặt trước ") { btn23.BackColor = Color.Yellow; btn23.Enabled = true; } else { btn23.BackColor = Color.Red; btn23.Enabled = true; }
            if (grdAN[2, 23].Value.ToString() == "Trống") { btn24.BackColor = Color.LimeGreen; btn24.Enabled = true; } else if (grdAN[2, 23].Value.ToString() == " đặt trước ") { btn24.BackColor = Color.Yellow; btn24.Enabled = true; } else { btn24.BackColor = Color.Red; btn24.Enabled = true; }
            if (grdAN[2, 24].Value.ToString() == "Trống") { btn25.BackColor = Color.LimeGreen; btn25.Enabled = true; } else if (grdAN[2, 24].Value.ToString() == " đặt trước ") { btn25.BackColor = Color.Yellow; btn25.Enabled = true; } else { btn25.BackColor = Color.Red; btn25.Enabled = true; }
            if (grdAN[2, 25].Value.ToString() == "Trống") { btn26.BackColor = Color.LimeGreen; btn26.Enabled = true; } else if (grdAN[2, 25].Value.ToString() == " đặt trước ") { btn26.BackColor = Color.Yellow; btn26.Enabled = true; } else { btn26.BackColor = Color.Red; btn26.Enabled = true; }
            if (grdAN[2, 26].Value.ToString() == "Trống") { btn27.BackColor = Color.LimeGreen; btn27.Enabled = true; } else if (grdAN[2, 26].Value.ToString() == " đặt trước ") { btn27.BackColor = Color.Yellow; btn27.Enabled = true; } else { btn27.BackColor = Color.Red; btn27.Enabled = true; }
            if (grdAN[2, 27].Value.ToString() == "Trống") { btn28.BackColor = Color.LimeGreen; btn28.Enabled = true; } else if (grdAN[2, 27].Value.ToString() == " đặt trước ") { btn28.BackColor = Color.Yellow; btn28.Enabled = true; } else { btn28.BackColor = Color.Red; btn28.Enabled = true; }
            if (grdAN[2, 28].Value.ToString() == "Trống") { btn29.BackColor = Color.LimeGreen; btn29.Enabled = true; } else if (grdAN[2, 28].Value.ToString() == " đặt trước ") { btn29.BackColor = Color.Yellow; btn29.Enabled = true; } else { btn29.BackColor = Color.Red; btn29.Enabled = true; }
            if (grdAN[2, 29].Value.ToString() == "Trống") { btn30.BackColor = Color.LimeGreen; btn30.Enabled = true; } else if (grdAN[2, 29].Value.ToString() == " đặt trước ") { btn30.BackColor = Color.Yellow; btn30.Enabled = true; } else { btn30.BackColor = Color.Red; btn30.Enabled = true; }


        }
    }
}
