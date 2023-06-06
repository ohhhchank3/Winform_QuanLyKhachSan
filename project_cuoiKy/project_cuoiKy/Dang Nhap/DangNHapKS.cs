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
using System.Globalization;
namespace project_cuoiKy
{
    public partial class DangNHapKS : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da3 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt2 = new DataTable();
        SqlCommand cmd = new SqlCommand();
        string sql, connstr, sql1;
        int i = 0;
        SqlDataReader dr;
        public DangNHapKS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbcheck_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcheck.Checked == true)
            {
                txtMK.UseSystemPasswordChar = true;
            }    
            else
            {
                txtMK.UseSystemPasswordChar = false;
            }    
        }
        private int LeapYear(int year)
        {
            if (year % 400 == 0) return 1;
            else if (year % 100 != 0 && year % 4 == 0) return 1;
            return 0;
        }
        private int KhoangCach2Ngay(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int dateOfYear = 0, dateOfMonth = 0, date = 0;

            /* Tinh khoang cach so ngay giua 2 nam */
            for (int i = y1; i < y2; i++)
                if (LeapYear(i) == 1)
                {
                    dateOfYear += 366;
                }//////
                else dateOfYear += 365;

            /* Tinh khoang cach so ngay giua 2 thang */
            int[] a = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (LeapYear(y2) == 1) a[1] = 29;           /////
            if (m1 > m2)
            {
                for (int i = m2; i < m1; i++)
                    dateOfMonth -= a[i - 1];
            }
            else
            {
                for (int i = m1; i < m2; i++)
                    dateOfMonth += a[i - 1];
            }

            /* Tinh khoang cach giua 2 ngay */
            date = y2 - y1 + 1;       //Ket qua tinh ca ngay cuoi cung

            int yes2 = dateOfMonth + dateOfYear + date;
            return yes2;
            // cout << "Result:   " << dateOfYear + dateOfMonth + date;
            //  cout << " date.";
            //  return 0;
        }
        private bool checkNamNhuan(int z)
        {
            if (((z % 4 == 0) && (z % 100 != 0)) ||
        (z % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DongBoHoa()
        {
            try
            {
                sql1 = "select idhdp from hoadonphong,PhongDatTruoc1  where PhongDatTruoc1.idphong = hoadonphong.idphong and hoadonphong.idphong in (select idphong from PhongDatTruoc1  where day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 and [check] = 1 ) and ngaycheckout is null and PhongDatTruoc1.[check] = 1 ";
                da1 = new SqlDataAdapter(sql1, conn);
                dt2.Clear();
                da1.Fill(dt2);
                //sql22 = "";
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    // lấy phòng cần thanh toán 
                    // string
                    string sql1 = "SELECT hoadonphong.idphong, sogiuong, loaiphong, giaphong, hoten, FORMAT (ngaycheckin, 'dd/MM/yyyy '), cmnd, DAY(GETDATE()) - DAY(ngaycheckin), idhdp,FORMAT (ngaycheckout, 'dd/MM/yyyy ') FROM dbo.phong, dbo.khachhang, dbo.hoadonphong "
                         + "WHERE hoadonphong.idkh = khachhang.idkh AND hoadonphong.idphong = phong.idphong AND ngaycheckout IS NULL "
                         + "AND hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + "";
                    da3 = new SqlDataAdapter(sql1, conn);
                    dt3.Clear();
                    da3.Fill(dt3);
                    DateTime d1 = DateTime.Now;
                    DateTime d2 = Convert.ToDateTime(dt3.Rows[0].ItemArray[5].ToString());
                    int h1 = Convert.ToInt16(d2.Day);
                    int j1 = Convert.ToInt16(d2.Month);
                    int k1 = Convert.ToInt16(d2.Year);
                    int h2 = Convert.ToInt16(d1.Day);
                    int j2 = Convert.ToInt16(d1.Month);
                    int k2 = Convert.ToInt16(d1.Year);

                    // Tính khoảng cách
                    // int z = 0;
                    int z = KhoangCach2Ngay(h1, j1, k1, h2, j2, k2);
                    if (z == 0)
                    {
                        z = 1;
                    }

                    sql = "UPDATE dbo.phong SET trangthai=N'Trống' WHERE idphong in (select phong.idphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and phong.idphong in (select PhongDatTruoc1.idphong from PhongDatTruoc1 where Day(ngaycheckin) - Day(getdate()) = 0) and hoadonphong.ngaycheckout is null and hoadonphong.idhdp = " + Convert.ToInt16(dt2.Rows[i][0]) + ");" +
               "UPDATE dbo.hoadonphong SET tienphong = " + z + " * (select phong.giaphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and hoadonphong.idphong in(select  PhongDatTruoc1.idphong from PhongDatTruoc1 ) and hoadonphong.ngaycheckout is null and idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") " +
                "WHERE hoadonphong.idphong in (select PhongDatTruoc1.idphong from PhongDatTruoc1 ) and ngaycheckout is null and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ";" +
                "UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv*hoadondv.soluong) from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and hoadondv.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + " ) where hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ";" +
                //  "UPDATE dbo.hoadonphong SET tienphong = (select day(PhongDatTruoc1.ngaycheckin) - day(hoadonphong.ngaycheckin) from hoadonphong,PhongDatTruoc1 where PhongDatTruoc1.idphong = hoadonphong.idphong and   hoadonphong.idphong in(select  PhongDatTruoc1.idphong from PhongDatTruoc1) and PhongDatTruoc1.idphong in (select PhongDatTruoc1.idphong from PhongDatTruoc1 where Day(ngaycheckin) -Day(getdate()) = 0) and hoadonphong.ngaycheckout is null and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") * (select phong.giaphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and hoadonphong.idphong in(select  PhongDatTruoc1.idphong from PhongDatTruoc1 ) and hoadonphong.ngaycheckout is null and idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") " +
                "UPDATE dbo.hoadonphong SET tiendichvu = 0 where hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + " and tiendichvu is null ;" +
                "UPDATE dbo.hoadonphong SET tongtien = (select tienphong + tiendichvu from hoadonphong where hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") where hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ";" +
                    //" UPDATE dbo.hoadonphong SET tienphong = (select phong.giaphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and hoadonphong.ngaycheckout is null and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") WHERE  ngaycheckout is null  and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ";" +

                    "UPDATE dbo.hoadonphong SET ngaycheckout = (select PhongDatTruoc1.ngaycheckin from PhongDatTruoc1,hoadonphong where hoadonphong.idphong = PhongDatTruoc1.idphong and ngaycheckout is null and day(PhongDatTruoc1.ngaycheckin)-day(getdate()) = 0 and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ")" +
                    "WHERE hoadonphong.idphong in (select PhongDatTruoc1.idphong from PhongDatTruoc1 where day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 ) and ngaycheckout is null and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ";" +
                   "INSERT INTO dbo.hoadonphong( idkh ,idphong,ngaycheckin) VALUES( (SELECT idkh FROM dbo.PhongDatTruoc1 WHERE SoTT = (select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong  and day(PhongDatTruoc1.ngaycheckin)-day(getdate()) = 0 and  PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + " )) and day(PhongDatTruoc1.ngaycheckin)-day(getdate()) = 0 ), (SELECT idphong FROM dbo.PhongDatTruoc1 WHERE SoTT = (select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and  day(PhongDatTruoc1.ngaycheckin)-day(getdate()) = 0  and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + " )) and day(PhongDatTruoc1.ngaycheckin)-day(getdate()) = 0 ), (SELECT ngaycheckin FROM dbo.PhongDatTruoc1 WHERE SoTT = (select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and   day(PhongDatTruoc1.ngaycheckin)-day(getdate()) = 0 and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + " )) and day(PhongDatTruoc1.ngaycheckin)-day(getdate()) >= 0 )) ;" +
                   "update dbo.phong set trangthai = N'Có Người' where phong.idphong = (select idphong from hoadonphong where hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") ;" +
                  "update  PhongDatTruoc1 set [check] = 0 where SoTT = (select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong  and day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + " );";




                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //String sqieu = "delete from PhongDatTruoc1 where SoTT = (select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and ngaycheckout is null and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ")";

                    // fn.setData(sql1);
                }
                if(cbADMIN.Checked == true)
                {
                    MessageBox.Show("Đồng bộ hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra ");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRDangKY fc = new FRDangKY();
            fc.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cbADMIN.Checked == true && cbKhach.Checked == false)
            {
                Bientoancuc.savetaikhoan = txtTK.Text;
                Bientoancuc.savematkhau = txtMK.Text;
                sql = "SELECT * FROM dbo.dangnhap WHERE tdn = '" + txtTK.Text + "' AND mk = '" + txtMK.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                if (i < 3)
                {

                    if (dt.Rows.Count != 0)
                    {
                        dt.Clear();
                        //fmanhinhchinh f = new fmanhinhchinh(txttdn.Text);
                        FrManHinhChinh f = new FrManHinhChinh(txtTK.Text);
                        f.ShowDialog();
                        txtTK.Text = "";
                        txtMK.Text = "";
                        cbADMIN.Checked = false;
                    }
                    else
                    {
                        i++;
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (i == 3)
                        {
                            MessageBox.Show("Bạn nhập sai quá nhiều lần", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMK.Text = "";
                            txtTK.Text = "";
                            cbADMIN.Checked = false;
                            DangNhap_ThatBai tb = new DangNhap_ThatBai();
                            tb.ShowDialog();
                             //this.Close();
                        }
                    }
                }

            }
            else if (cbKhach.Checked == true && cbADMIN.Checked == false)
            {
                Bientoancuc.savetaikhoan = txtTK.Text;
                Bientoancuc.savematkhau = txtMK.Text;
 
                //cmd.CommandText = "SELECT IdTaiKhoan from TAIKHOAN where taikhoan =N'"+txtTK.Text+"'";
                //d/r = cmd.ExecuteReader();

                // while (dr.Read())
                // {
                //  listBox1.Items.Add(dr["CompanyName"]);


                //  }
                sql = "SELECT * FROM TAIKHOAN WHERE TaiKhoan = '" + txtTK.Text + "' AND MatKhau = '" + txtMK.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                if (i < 3)
                {
                    sql1 = "select IdTaiKhoan from TAIKHOAN where TAIKHOAN.TaiKhoan = N'" + txtTK.Text + "'";
                    da1 = new SqlDataAdapter(sql1, conn);

                    dt2.Clear();
                    da1.Fill(dt2);
                    Bientoancuc.saveIDKH = Convert.ToString(dt2.Rows[0].ItemArray[0]);
                    if (dt.Rows.Count != 0)
                    {
                        dt.Clear();
                        //fmanhinhchinh f = new fmanhinhchinh(txttdn.Text);
                        ManHinhChinh f = new ManHinhChinh();
                        f.ShowDialog();
                        txtMK.Text = "";
                        txtTK.Text = "";
                        //txthoten.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);

                        // txtTK.Text = "";
                        // txtMK.Text = "";
                        //cbADMIN.Checked = false;
                        cbKhach.Checked = false;
                    }
                    else
                    {
                        i++;
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (i == 3)
                        {
                            MessageBox.Show("Bạn nhập sai quá nhiều lần", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbKhach.Checked = false;
                            //txtMK.Text = "";
                            //txtTK.Text = "";
                            DangNhap_ThatBai tb = new DangNhap_ThatBai();
                            tb.ShowDialog();

                            // Application.Exit();
                            //this.Close();
                        }
                    }

                }


            }
        }

        private void DangNHapKS_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "Select tenks,tenchuks,diachi,sdt,masothue,FORMAT(ngaythanhlap, 'dd-MM-yyyy') AS 'ngaythanhlap',logofile from dbo.thongtin";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            Bientoancuc.tenks = dt.Rows[0].ItemArray[0].ToString();
            Bientoancuc.tenchuks = dt.Rows[0].ItemArray[1].ToString();
            Bientoancuc.diachi = dt.Rows[0].ItemArray[2].ToString();
            Bientoancuc.sdt = dt.Rows[0].ItemArray[3].ToString();
            Bientoancuc.masothue = dt.Rows[0].ItemArray[4].ToString();
            Bientoancuc.ngaythanhlap = DateTime.Parse(dt.Rows[0].ItemArray[5].ToString(),CultureInfo.CreateSpecificCulture("fr-FR"));
            Bientoancuc.logofile = dt.Rows[0].ItemArray[6].ToString();
            i = 0;
        }
    }
}
