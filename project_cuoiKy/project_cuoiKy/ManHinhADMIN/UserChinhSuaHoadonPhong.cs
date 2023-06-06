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
    public partial class UserChinhSuaHoadonPhong : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtkt = new DataTable();
        string sql,sql1, connstr;
        int i;
        function fn = new function();
        bool flag; // cờ kiểm tra xem khách mới hay cũ
        public UserChinhSuaHoadonPhong()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            try
            {
                //  i = grdkhachhang1.CurrentRow.Index;
                //   txtcmnd.Text = grdkhachhang1[0, i].Value.ToString();
                // txtHoTen.Text = grdkhachhang1[1, i].Value.ToString();
                //   txtDiachi.Text = grdkhachhang1[2, i].Value.ToString();
                i = grdPhong.CurrentRow.Index;
                lbidhdp.Text = grdPhong[0, i].Value.ToString();
                txtIdkh.Text = grdPhong[1, i].Value.ToString();
                txtdientichvu.Text = grdPhong[7, i].Value.ToString();
                txtidphong.Text = grdPhong[2, i].Value.ToString();
                txttienphong.Text = grdPhong[6, i].Value.ToString();
                txttongtien.Text = grdPhong[5, i].Value.ToString();
                dtpngayden.Value = Convert.ToDateTime(grdPhong[3, i].Value.ToString());
                dtpngayroidi.Value = Convert.ToDateTime(grdPhong[4, i].Value.ToString());
                guna2Button5.Enabled = true;
                
               // txtngaycheckin.Text = grdPhong[3, i].Value.ToString();
               // txtngaycheckout.Text = grdPhong[4, i].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
   
        private void UserChinhSuaHoadonPhong_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT idhdp,idkh,idphong,ngaycheckin,ngaycheckout,tongtien,tienphong,tiendichvu from hoadonphong";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
            guna2Button5.Enabled = false;
            //grdPhong.Enabled = false;
        }
        public void Loaddata(String qur)
        {
            DataSet ds = fn.getData(qur);
            grdPhong.DataSource = ds.Tables[0];
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if( txttienphong.Text == "")
            {
                txttienphong.Text = "0";
            } 
            if (txtdientichvu.Text == "")
            {
                txtdientichvu.Text = "0";
            }    
            if(txttongtien.Text == "")
            {
                txttongtien.Text = "0";
            } 
            string ngayden = dtpngayden.Value.ToString("yyyy-MM-dd");
            string ngayroidi = dtpngayroidi.Value.ToString("yyyy-MM-dd");
            if(rbtncheck.Checked == true)
            {
                String sqll = "update dbo.hoadonphong set idkh = " + int.Parse(txtIdkh.Text) + ",ngaycheckin = '" + ngayden + "',ngaycheckout = '" + ngayroidi + "',idphong ='" + txtidphong.Text + "',tienphong =" + float.Parse(txttienphong.Text) + ",tiendichvu = " + float.Parse(txtdientichvu.Text) + ",tongtien = " + float.Parse(txttongtien.Text) + " where idhdp = " + int.Parse(lbidhdp.Text) + "";
                fn.setData(sqll);
            }    
            else
            {
                String sqll = "update dbo.hoadonphong set idkh = " + int.Parse(txtIdkh.Text) + ",ngaycheckin = '" + ngayden + "',idphong ='" + txtidphong.Text + "',tienphong =" + float.Parse(txttienphong.Text) + ",tiendichvu = " + float.Parse(txtdientichvu.Text) + ",tongtien = " + float.Parse(txttongtien.Text) + " where idhdp = " + int.Parse(lbidhdp.Text) + "";
                fn.setData(sqll);
            }    
         
            String z = " SELECT idhdp, idkh, idphong, ngaycheckin, ngaycheckout, tongtien, tienphong, tiendichvu from hoadonphong";
            Loaddata(z);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            float k = float.Parse(txttienphong.Text) + float.Parse(txtdientichvu.Text);
            txttongtien.Text = Convert.ToString(k.ToString());

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Bientoancuc.saveIdHDPhong = int.Parse(lbidhdp.Text);
            FrChinhSuaHoaDonDVToHoaDonP n = new FrChinhSuaHoaDonDVToHoaDonP();
            n.ShowDialog();
          
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
          if(  guna2Button5.Enabled == true)
            {
                guna2Button5.Enabled = false;
            }
            else
            {
                guna2Button5.Enabled = true;
            } 
                
        }

        private void guna2Button5_Leave(object sender, EventArgs e)
        {
            dt.Clear();
            sql = "SELECT idhdp,idkh,idphong,ngaycheckin,ngaycheckout,tongtien,tienphong,tiendichvu from hoadonphong";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                string z = Convert.ToString(txttiemkiem.Text);
                string test = z.Substring(0, 1);
                char c = Convert.ToChar(test);
                // char c =Char.Parse(z.ToString());
                if (Char.IsLetter(c) == true)
                {
                    sql1 = "SELECT idhdp,idkh,idphong,ngaycheckin,ngaycheckout,tongtien,tienphong,tiendichvu from hoadonphong  where  idphong  =  '" + txttiemkiem.Text + "'  ";
                }
                else
                {
                    sql1 = "SELECT idhdp,idkh,idphong,ngaycheckin,ngaycheckout,tongtien,tienphong,tiendichvu from hoadonphong  where   idhdp = " + int.Parse(txttiemkiem.Text) + "  or idkh = " + int.Parse(txttiemkiem.Text) + "  ";
                }

                da = new SqlDataAdapter(sql1, conn);
                da.Fill(dt);
                grdPhong.DataSource = dt;
                grdPhong.Refresh();
            }
            catch (Exception ex)
            {
                dt.Clear();
                sql = "SELECT idhdp,idkh,idphong,ngaycheckin,ngaycheckout,tongtien,tienphong,tiendichvu from hoadonphong";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdPhong.DataSource = dt;
                grdPhong.Refresh();
            }

        }

        private void grdPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
    }
}
