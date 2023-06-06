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
    public partial class UserKhachHangTraPhong : UserControl
    {
        function fn = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dtdv = new DataTable();
        DataTable dtrpt = new DataTable();
        string sql, sql1, sql2, sql3, connstr;
        int tt, ttdv;
        string ngaydenhoadon;
        private int namNhuan(int y)
        {
            if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                return 1;
            else return 0;
        }

        private void ConvertThan1g(int m, int k, int z)
        {
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                k = 30;
            }
            else if (m == 5 || m == 10 || m == 7 || m == 3 || m == 12)
            {
                k = 31;
            }
            else if (m == 2)
            {
                if (((z % 4 == 0) && (z % 100 != 0)) ||
        (z % 400 == 0))
                {
                    k = 29;
                }
                else
                {
                    k = 28;
                }
            }

        }
        private int LeapYear(int year)
        {
            if (year % 400 == 0) return 1;
            else if (year % 100 != 0 && year % 4 == 0) return 1;
            return 0;
        }
        private int SoNgayTrongThang(int m, int y)
        {
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30; break;
                case 2:
                    if (namNhuan(y) == 1) return 29;
                    else return 28;
                    break;
                default: return 31;
            }
        }
        private int ConLai(int d, int m, int y)
        {
            int SoNgay = SoNgayTrongThang(m, y) - d;
            for (int i = m + 1; i <= 12; i++)
                SoNgay += SoNgayTrongThang(i, y);
            return SoNgay;
        }
        private int stt(int d, int m, int y)
        {
            int SoNgay = d;
            for (int i = m - 1; i > 0; i--)
                SoNgay += SoNgayTrongThang(i, y);
            return SoNgay;
        }

        private int KhoangCach2Ngay(int d1, int m1, int y1, int d2, int m2, int y2)
        {

            //So ngay tu dd/mm/yyyy den 31/12/yyyy



            int sign, SoNgay;
            if (y1 == y2)
            {
                SoNgay = stt(d1, m1, y1) - stt(d2, m2, y2);
                if (SoNgay < 0) return -SoNgay;
                else return SoNgay;
            }
            else if (y1 < y2)
            {
                SoNgay = stt(d2, m2, y2) + ConLai(d1, m1, y1);
                sign = 1;
            }
            else
            {
                SoNgay = ConLai(d2, m2, y2) + stt(d1, m1, y1);
                sign = -1;
            }

            //Tru ra so ngay StartYear
            if (namNhuan(y1) == 1) SoNgay -= 366;
            else SoNgay -= 365;
            while (y1 != y2)
            {
                if (namNhuan(y1) == 1) SoNgay += 366;
                else SoNgay += 365;
                y1 = y1 + sign;
            }
            return SoNgay;
        }
        private void btndientt_Click(object sender, EventArgs e)
        {
            try
           {
                sql = "SELECT hoadonphong.idphong, sogiuong, loaiphong, giaphong,  FORMAT (ngaycheckin, 'dd/MM/yyyy '),DAY(GETDATE()) - DAY(ngaycheckin),idhdp,cmnd,hoten FROM dbo.phong, dbo.khachhang, dbo.hoadonphong "
                    + "WHERE hoadonphong.idkh = khachhang.idkh AND hoadonphong.idphong = phong.idphong AND ngaycheckout IS NULL "
                    + "AND hoadonphong.idphong = '" + txtidphong.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                lblmaphong.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
                lblsogiuong.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                lblloai.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                lblsongaythue.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                lblgiatien.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                int k = Convert.ToInt16(lblsongaythue.Text);
                ngaydenhoadon = dt.Rows[0].ItemArray[4].ToString();
                DateTime d1 = DateTime.Now;
                DateTime d2 = Convert.ToDateTime(dt.Rows[0].ItemArray[4].ToString());
                int h1 = Convert.ToInt16(d2.Day);
                int j1 = Convert.ToInt16(d2.Month);
                int k1 = Convert.ToInt16(d2.Year);
                int h2 = Convert.ToInt16(d1.Day);
                int j2 = Convert.ToInt16(d1.Month);
                int k2 = Convert.ToInt16(d1.Year);
                int z = KhoangCach2Ngay(h1, j1, k1, h2, j2, k2) + 1;
                
                if (z == 0)
                {
                    lblsongaythue.Text = "1";
                }
             
                lblidhdphong.Text = Convert.ToString(dt.Rows[0].ItemArray[6]);
                string kz = Convert.ToString(dt.Rows[0].ItemArray[6]);
                Bientoancuc.savehoten = Convert.ToString(dt.Rows[0].ItemArray[7]);
                Bientoancuc.cmnd = Convert.ToString(dt.Rows[0].ItemArray[8]);

                sql = "SELECT dichvu.tendv, giadv, soluong,(giadv*soluong) AS 'tongtien', ngaygoi "
                + "FROM dbo.hoadondv, dbo.dichvu "
                + "WHERE idhdp IN (SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" + txtidphong.Text + "' AND ngaycheckout IS NULL) "
                + "AND dichvu.tendv = hoadondv.tendv";
                da = new SqlDataAdapter(sql, conn);
                dtdv.Clear();
                da.Fill(dtdv);
                grddv.DataSource = dtdv;
                grddv.Refresh();

                //Tính tổng tiền
                lblsongaythue.Text = Convert.ToString(z);
                if(lblsongaythue.Text == "0")
                {
                    lblsongaythue.Text = "1";
                }    
                giaphong = Convert.ToInt32(lblgiatien.Text);
                ttdv = 0;
                for (int i = 0; i <= grddv.RowCount - 2; i++)
                {
                    ttdv = ttdv + Convert.ToInt32(grddv[3, i].Value.ToString());
                }
                tienphong = giaphong * (Convert.ToInt16(lblsongaythue.Text));
                tt = tienphong + ttdv;
                txttongtien.Text = tt.ToString();
                txtkhachdua.Text = txttongtien.Text;
              //  txttralai.Text = "0";
                //btndientt.Enabled = false;
                Bientoancuc.savePhong = lblmaphong.Text.ToString();
                Bientoancuc.savePhong = lblmaphong.Text.ToString();
                Bientoancuc.saveIdHDPhong = Convert.ToInt16(kz.ToString());
                //Bientoancuc.saveIdHDPhong = Convert.ToInt16(kz.ToString());
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }

        int giaphong;

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            string pt = "Thẻ";
            try
            {
                bool isNum = true;
                if (rbtnthe.Checked)
                {
                    if (txtidphong.Text != "")
                    {

                        if ( isNum == true)
                        {


                          
                                if (MessageBox.Show("Thanh toán và in hóa đơn ? ", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                                {
                                    // không thể có 2 phòng vừa có người và ngày check out lại null
                                    sql = "UPDATE dbo.phong SET trangthai=N'Trống' WHERE idphong = '" + txtidphong.Text + "';" +
                                    "UPDATE dbo.hoadonphong SET tongtien = '" + txttongtien.Text + "' WHERE idhdp = '" + lblidhdphong.Text + "';" +
                                    "UPDATE dbo.hoadonphong SET tienphong = '" + tienphong.ToString() + "' WHERE idhdp = '" + lblidhdphong.Text + "';" +
                                    "UPDATE dbo.hoadonphong SET tiendichvu = '" + ttdv.ToString() + "' WHERE idhdp = '" + lblidhdphong.Text + "';" +
                                    "UPDATE dbo.hoadonphong SET phuongthuctt = N'" + pt.ToString() + "' where idhdp = '" + lblidhdphong.Text + "';" +
                                    "UPDATE dbo.hoadonphong SET ngaycheckout = GETDATE() WHERE idhdp = '" + lblidhdphong.Text + "';";
                                    cmd = new SqlCommand(sql, conn);
                                    cmd.ExecuteNonQuery();


                                    // In hóa đơn
                                    sql = "SELECT dichvu.tendv, giadv as tiendichvu , soluong, (giadv * soluong) AS thanhtien FROM dbo.hoadondv, dbo.hoadonphong, dbo.dichvu " +
                                        "WHERE hoadondv.idhdp = hoadonphong.idhdp " +
                                        "AND dichvu.tendv = hoadondv.tendv " +
                                        "AND hoadondv.idhdp = '" + lblidhdphong.Text + "' ";
                                    da = new SqlDataAdapter(sql, conn);
                                //    da.Fill(dtrpt);
                                MessageBox.Show("Thanh toan thành cônbg", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KhachHangInHoaDon new1 = new KhachHangInHoaDon();
                                new1.ShowDialog();
                                }

                            }
                            lblmaphong.Text = "";
                            lblsogiuong.Text = "";
                            lblloai.Text = "";
                            lblgiatien.Text = "";

                            ngaydenhoadon = "";

                            lblsongaythue.Text = "";
                            lblidhdphong.Text = "";
                            txttongtien.Text = "";
                            txtkhachdua.Text = "";
                            //txttralai.Text = "";
                            txtidphong.Text = "";


                        }
                        // thể có 2 phòng vừa có người và ngày check out lại null


                        //  fn.setData(queeei);


                        //Bientoancuc.cmnd = "";
                        // Bientoancuc.savehoten = "";
                        //  txtidphong.Text = "";

                        //Reset dữ liệu





                        else
                        {
                            MessageBox.Show("Vui lòng điền thông tin chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền thông tin chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                

            }
            catch (Exception ex)
            {

            }
        }

        private void btntimphong_Click(object sender, EventArgs e)
        {
            TimPhong f = new TimPhong();
            f.TruyenData = new TimPhong.TruyenChoCha(LoadData);
            f.ShowDialog();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            KhachHangInHoaDon n = new KhachHangInHoaDon();
            n.ShowDialog();
        }

        int tienphong;
        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] placeValues = new string[] { "", "Nghìn", "Triệu", "Tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "Một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "Lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "Lẻ " + result;
                        if (tens == 1) result = "Mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " Mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " Trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " Đồng" : "");
        }
        public UserKhachHangTraPhong()
        {
            InitializeComponent();
        }
        private void LoadData(string data)
        {
            txtidphong.Text = "";
            txtidphong.Text = data;
        }
        private void UserKhachHangTraPhong_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            lblsongaythue.Enabled = false;
            lblmaphong.Enabled = false;
            lblgiatien.Enabled = false;
            lblloai.Enabled = false;
            lblsogiuong.Enabled = false;
            txtkhachdua.Enabled = false;
            txttongtien.Enabled = false;
        }
    }
}
