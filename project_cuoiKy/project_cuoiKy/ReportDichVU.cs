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
using Microsoft.Reporting.WinForms;

namespace project_cuoiKy
{
    public partial class ReportDichVU : Form
    {
        public ReportDichVU()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            string fromStr = dtp1.Value.ToString("yyyy-MM-dd");
            string toStr = dtp2.Value.ToString("yyyy-MM-dd");
            DateTime d1 = Convert.ToDateTime(fromStr);
            DateTime d2 = Convert.ToDateTime(toStr);
            String sql = "SELECT    hoadondv.*, dichvu.tendv AS Expr1, dichvu.giadv, dichvu.donvi,dichvu.giadv * soluong  FROM hoadondv INNER JOIN dichvu ON hoadondv.tendv = dichvu.tendv where hoadondv.ngaygoi >= convert(datetime,'" + fromStr + "') and ngaygoi <= convert(datetime,'" + toStr + "') ";
            



            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            con.ConnectionString = @"Data Source=VONHUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";

            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds1 = new DataSet();
            adp.Fill(ds1);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            //  rptViewer.LocalReport.ReportPath = "Report1.rdlc";
            //Nếu có dữ liệu
            if (ds1.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds1 = new ReportDataSource();
                rds1.Name = "DataSet1";
                rds1.Value = ds1.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu
                //  truy vấn khác
                rptViewer.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rptViewer.LocalReport.DataSources.Add(rds1);
                //Refresh lại báo cáo
                rptViewer.RefreshReport();
            }


        }
        private void ReportDichVU_Load(object sender, EventArgs e)
        {
          //  loaddata();
            //this.rptViewer.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void rptViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
