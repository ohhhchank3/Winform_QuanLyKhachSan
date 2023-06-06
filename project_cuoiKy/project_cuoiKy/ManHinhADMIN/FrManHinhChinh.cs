using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Data.SqlClient;

namespace project_cuoiKy
{
    public partial class FrManHinhChinh : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da3 = new SqlDataAdapter();
        // DataTable dt = new DataTable();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dtkt = new DataTable();
        DataTable dttenv = new DataTable();
        DataTable dtrpt = new DataTable();
        string sql, connstr, sql1;
        CultureInfo culture;
        string user;
        public FrManHinhChinh(string user)
        {
            InitializeComponent();
            //culture = CultureInfo.CurrentCulture;
            this.user = user;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaDanhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrManHinhChinh_Load(object sender, EventArgs e)
        {
            lbten.Text = "Màn hình chính ";
          

            UserADManhinhchinh fc = new UserADManhinhchinh();
            //guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();

            //Điền mã nhân viên và tên nhân viên
            lblmanv.Text = user;
            sql1 = "SELECT tennv FROM dbo.dangnhap WHERE tdn = '" + user + "'";
            da = new SqlDataAdapter(sql1, conn);
            da.Fill(dttenv);
            lbltennv.Text = dttenv.Rows[0].ItemArray[0].ToString();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thuê Phòng";
            UserADThuePhong fc = new UserADThuePhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            //fc.TopLevel = false;
           // fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
   
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lbten.Text = "Sử dụng dịch vụ";
    
            UserADSudungdichvu fc = new UserADSudungdichvu();
          //  guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
          
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lbten.Text = "Trả Phòng";
            UserADTraPhong fc = new UserADTraPhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
         
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lbten.Text = "Màn hình chính";
          
            UserADManhinhchinh fc = new UserADManhinhchinh();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();

        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lbten.Text = "Thuê Phòng";
            UserADThuePhong fc = new UserADThuePhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
         
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lbten.Text = "Sử dụng dịch vụ";
            UserADSudungdichvu fc = new UserADSudungdichvu();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Trả phòng";
            UserADTraPhong fc = new UserADTraPhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }

        private void danhMụcDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lbten.Text = "Danh mục dịch vụ";
            UserADDichVu fc = new UserADDichVu();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();

        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lbten.Text = "Danh mục khách hàng";
            UserAdDanhMucKhachHang fc = new UserAdDanhMucKhachHang();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();


        }

        private void danhMụcPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Danh mục phòng";
            UserADQuanLyPhong fc = new UserADQuanLyPhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
          
         
        }

        private void tạoTàiKhoảnChoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Tạo tài khoản khách hàng";
            UserADTaiKhoanKH fc = new UserADTaiKhoanKH();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
           
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Đổi mật khẩu ";
            UserADDoimatKhauNhanVien fc = new UserADDoimatKhauNhanVien();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
         
          
        }

        private void chỉnhSửaHóaĐơnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Chỉnh sửa hóa đơn phòng";
            UserChinhSuaHoadonPhong fc = new UserChinhSuaHoadonPhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
           
           
        }

        private void chỉnhSửaHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Chỉnh sửa hóa đơn dịch vụ";
            //userADChinhSuaHoaDonDV1.Visible = true;
            UserADChinhSuaHoaDonDV fc = new UserADChinhSuaHoaDonDV();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }

        private void xemDanhSáchPhòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Danh sách phòng đang thuê";
            FrQuanLyTienTrinhDangThue f = new FrQuanLyTienTrinhDangThue();
            //f.ShowDialog();
          
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
           f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(f);
            f.Show();
        
        }

        private void xemDanhSáchPhòngĐặtTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Danh sách phòng đặt trước";
            UserADDanhsachPhongDatTruoc fc = new UserADDanhsachPhongDatTruoc();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void danhMụcTừĐiểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Danh mục từ điển";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SetLanguage(string cultureName)
        {
          //  culture = CultureInfo.CreateSpecificCulture(cultureName);
         ///  ResourceManager rm = new
            //    ResourceManager("WinFormsMultiLingual.Lang.MyResource", typeof(FrManHinhChinh).Assembly);

            //btnHello.Text = rm.GetString("hello", culture);
           // radEnglish.Text = rm.GetString("english", culture);
           // radVietnamese.Text = rm.GetString("vietnamese", culture);
           // helloWorldString = rm.GetString("helloworld", culture);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void danhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thống kê doanh thu";
            ThongKeDoanhThu fc = new ThongKeDoanhThu();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
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
        private void btndongbohoa_Click(object sender, EventArgs e)
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
                if(z == 0)
                {
                    z = 1;
                }    

                sql = "UPDATE dbo.phong SET trangthai=N'Trống' WHERE idphong in (select phong.idphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and phong.idphong in (select PhongDatTruoc1.idphong from PhongDatTruoc1 where Day(ngaycheckin) - Day(getdate()) = 0) and hoadonphong.ngaycheckout is null and hoadonphong.idhdp = " + Convert.ToInt16(dt2.Rows[i][0]) + ");" +
           "UPDATE dbo.hoadonphong SET tienphong = "+z+" * (select phong.giaphong from phong,hoadonphong where phong.idphong = hoadonphong.idphong and hoadonphong.idphong in(select  PhongDatTruoc1.idphong from PhongDatTruoc1 ) and hoadonphong.ngaycheckout is null and idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") " +
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
            MessageBox.Show("Đồng bộ hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // string filename = ";
            System.Diagnostics.Process.Start(@"C:\Users\vonhu\Downloads\123.pdf");
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thông tin khách sạn ";
            UserThongTinKS fc = new UserThongTinKS();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Báo cáo doanh thu ";
            ReportHoaDonPhong fc = new ReportHoaDonPhong();
            fc.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lbten.Text = "Báo cáo hóa đơn dịch vụ ";
            ReportDichVU fc = new ReportDichVU();
            fc.ShowDialog();
        }

        private void hiệuSuấtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thống kê số phòng";
            ThongKeThuePhong fc = new ThongKeThuePhong();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
           // fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }

        private void tỷLệĐặtPhòngOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thống kê thuê phòng ONline";
            UserThuePhongOnline fc = new UserThuePhongOnline();
            guna2ShadowPanel1.Show();
            guna2ShadowPanel1.Controls.Clear();
            // fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            guna2ShadowPanel1.Controls.Add(fc);
            fc.Show();
        }
    }
}
