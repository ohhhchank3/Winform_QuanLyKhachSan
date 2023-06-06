using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace project_cuoiKy
{
    public partial class KhachHangInHoaDon : Form
    {
        function fn = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        string sql, connstr, sql1;
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            dtgPhong.DataSource = ds.Tables[0];

        }
        public void loadData1(String qur)
        {


            DataSet ds1 = fn.getData(qur);
            dtgDichVU.DataSource = ds1.Tables[0];
            btnPrint.BackColor = Color.LightPink;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            //   printer.Footer = "Total Payable  Amount: " + lbToTal.Text;


            printer.FooterSpacing = 10;
            printer.PrintDataGridView(dtgPhong);
            DGVPrinter dgv = new DGVPrinter();
            dgv.Title = "Dịch vụ";
            dgv.PrintDataGridView(dtgDichVU);
            this.Close();
        }

        public KhachHangInHoaDon()
        {
            InitializeComponent();
        }

        private void KhachHangInHoaDon_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            String query = "select khachhang.hoten,khachhang.cmnd,khachhang.idkh,hoadonphong.idphong,hoadonphong.ngaycheckin,hoadonphong.ngaycheckout,hoadonphong.tienphong,hoadonphong.tongtien " +
       " from khachhang,hoadonphong " +
       " where hoadonphong.idhdp = " + int.Parse(Bientoancuc.saveIdHDPhong.ToString()) + " and hoadonphong.idkh = khachhang.idkh";
            loadData(query);
            //DataSet ds11 = fn.getData(query);

            String quee = "select hoadonphong.idkh,hoadonphong.idphong,hoadondv.tendv,hoadondv.ngaygoi,hoadondv.soluong,giadv,giadv * soluong AS thanhtien" +
                " from hoadondv,hoadonphong,dichvu " +
                " where hoadondv.idhdp = " + int.Parse(Bientoancuc.saveIdHDPhong.ToString()) + "  and hoadonphong.idhdp = hoadondv.idhdp and dichvu.tendv= hoadondv.tendv ";
            loadData1(quee);
            sql = "select khachhang.hoten,khachhang.cmnd,khachhang.idkh,hoadonphong.idphong,hoadonphong.ngaycheckin,hoadonphong.ngaycheckout,hoadonphong.tienphong,hoadonphong.tongtien from khachhang,hoadonphong  where hoadonphong.idhdp = " + int.Parse(Bientoancuc.saveIdHDPhong.ToString()) + " and hoadonphong.idkh = khachhang.idkh";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            txtHoten.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            txtSOCMT.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            txtPhong.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
            sql1 = "select sum(dichvu.giadv*hoadondv.soluong) as K from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and hoadondv.idhdp = " + Bientoancuc.saveIdHDPhong + " ";
            // int tongtien = 0;
            da1 = new SqlDataAdapter(sql1, conn);
            dt2.Clear();
            da1.Fill(dt2);

            //int  tiendichvu = 0;
            string tienphong = Convert.ToString(dt.Rows[0].ItemArray[7]);
            if (tienphong == "")
            {
                tienphong = "0";
            }
            string tien1 = Convert.ToString(dt2.Rows[0].ItemArray[0]);
            if (tien1 == "")
            {
                tien1 = "0";
            }
            int tiendichvu1 = Convert.ToInt32(tien1.ToString());
            int tienp1 = Convert.ToInt32(tienphong);
            int tongtien = tienp1 + tiendichvu1;
            txtTongTien.Text = Convert.ToString(tongtien.ToString());

        }
    }
}
