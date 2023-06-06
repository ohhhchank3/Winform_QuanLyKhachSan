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
    public partial class FrTiemKiemPhong1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string sql, connstr;
        int i;
        string tt, sogiuong, loai;
        string sophong;
        public delegate void TruyenChoCha(string s);

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            i = grdPhong.CurrentRow.Index;
            label1.Text = grdPhong[0, i].Value.ToString();
            TruyenData(label1.Text);
            MessageBox.Show("Chọn thành công");
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT idphong, hoten, ngaycheckin, cmnd FROM dbo.hoadonphong,dbo.khachhang "
                + "WHERE hoadonphong.idkh = khachhang.idkh AND ngaycheckout IS NULL AND hoten LIKE N'%" + txthoten.Text + "%' AND cmnd LIKE '%" + txtcmnd.Text + "%' "
                + "ORDER BY idphong ASC";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
        }

        public TruyenChoCha TruyenData;
        public FrTiemKiemPhong1()
        {
            InitializeComponent();
        }

        private void FrTiemKiemPhong1_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT phong.idphong, hoten, ngaycheckin, cmnd,trangthai" +
                " FROM dbo.hoadonphong,dbo.khachhang,phong "
                 + "WHERE hoadonphong.idkh = khachhang.idkh and phong.idphong = hoadonphong.idphong and phong.trangthai = N'Có người' and  ngaycheckout IS NULL" +
                 " ORDER BY idphong ASC";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdPhong.DataSource = dt;
            grdPhong.Refresh();
        }
    }
}
