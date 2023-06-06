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
    public partial class ReportHoaDonPhong : Form
    {
        public ReportHoaDonPhong()
        {
            InitializeComponent();
        }
        private void  loaddata()
        {
            string fromStr = dtp1.Value.ToString("yyyy-MM-dd");
            string toStr = dtp2.Value.ToString("yyyy-MM-dd");
            DateTime d1 = Convert.ToDateTime(fromStr);
            DateTime d2 = Convert.ToDateTime(toStr);
            String sql = "select * from hoadonphong where ngaycheckout >= convert(datetime,'"+fromStr+"') and ngaycheckout <= convert(datetime,'"+toStr+"') ";

            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            con.ConnectionString = @"Data Source=VONHUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
          
            SqlDataAdapter adp4 = new SqlDataAdapter(sql, con);
            DataSet ds2 = new DataSet();
            adp4.Fill(ds2);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            rptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
          //  rptViewer.LocalReport.ReportPath = "Report1.rdlc";
            //Nếu có dữ liệu
            if (ds2.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds2.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu
              //  truy vấn khác
              rptViewer.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rptViewer.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
               rptViewer.RefreshReport();
            }
        

    }
    private void ReportHoaDonPhong_Load(object sender, EventArgs e)
        {
            
           
            //loaddata();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
