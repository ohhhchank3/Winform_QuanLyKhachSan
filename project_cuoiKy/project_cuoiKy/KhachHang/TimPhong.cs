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
    public partial class TimPhong : Form
    {
        function fn = new function();


        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string connstr;
        int i;
        string tt, sogiuong, loai;
        string sophong;
        public delegate void TruyenChoCha(string s);
        public TruyenChoCha TruyenData;
        public TimPhong()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
            
               
                
                    i = grdPhong.CurrentRow.Index;
                    guna2HtmlLabel1.Text = grdPhong[0, i].Value.ToString();
                    TruyenData(guna2HtmlLabel1.Text);
                    MessageBox.Show("Chọn thành công");
                    this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            grdPhong.DataSource = ds.Tables[0];

        }
        private void TimPhong_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            try
            {
                String sql = "SELECT phong.idphong, hoten, ngaycheckin, cmnd,phong.trangthai " +
                    " FROM dbo.hoadonphong,dbo.khachhang,phong "
                   + "WHERE hoadonphong.idkh = khachhang.idkh AND phong.idphong = hoadonphong.idphong and phong.trangthai = N'Có người' and  ngaycheckout IS NULL AND hoadonphong.idkh = " + int.Parse(Bientoancuc.saveIDKH) + " " +
                                    "ORDER BY idphong ASC ";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                grdPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
