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
    public partial class UserKhachHangDichVu : UserControl
    {
        function fn = new function();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, sql1, connstr, timkiem;
        int i, sl;

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntiemkiem_Click(object sender, EventArgs e)
        {
            if (txttiemkiem.Text == "Nhập tên dịch vụ") timkiem = "";
            else timkiem = txttiemkiem.Text;
            sql = "SELECT * FROM dbo.dichvu WHERE tendv LIKE N'%" + timkiem + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddv.DataSource = dt;
            grddv.Refresh();
        }

        private void btntangsl_Click(object sender, EventArgs e)
        {
            sl++;
            txtsoluong.Text = sl.ToString();
        }

        private void btngiamsl_Click(object sender, EventArgs e)
        {
            if (sl > 0)
            {
                sl--;
                txtsoluong.Text = sl.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txttendv.Text != "" && cmbsophong.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    string ngaygoi = dtpngaygoi.Value.ToString("yyyy-MM-dd");
                    sql = "INSERT INTO dbo.hoadondv( idhdp, tendv, ngaygoi, soluong )VALUES"
                         + "((SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" + cmbsophong.Text + "' AND ngaycheckout IS NULL),N'" + txttendv.Text + "','" + ngaygoi + "','" + txtsoluong.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    String k = "UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv * hoadondv.soluong) from hoadondv, dichvu where dichvu.tendv = hoadondv.tendv and hoadondv.idhdp = (SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" + cmbsophong.Text + "' AND ngaycheckout IS NULL) ) where hoadonphong.idhdp = (SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" + cmbsophong.Text + "' AND ngaycheckout IS NULL) ";
                    fn.setData(k);
                    MessageBox.Show("thêm thành công");
                    txttendv.Text = "";
                    txtgiadv.Text = "";
                    txtsoluong.Text = "1";
                    cmbsophong.Text = "";
                    sl = 1;

                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grddv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        public UserKhachHangDichVu()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            i = grddv.CurrentRow.Index;
            txttendv.Text = grddv[0, i].Value.ToString();
            txtgiadv.Text = grddv[2, i].Value.ToString();
        }

        private void btntangsl_Click_1(object sender, EventArgs e)
        {
            sl++;
            txtsoluong.Text = sl.ToString();
        }

        private void btngiamsl_Click_1(object sender, EventArgs e)
        {
            if (sl > 0)
            {
                sl--;
                txtsoluong.Text = sl.ToString();
            }
        }

        public void loadData(string qur)
        {


            DataSet ds = fn.getData(qur);
            grddv.DataSource = ds.Tables[0];

        }
        public void loadData1(string qur)
        {


            DataSet ds = fn.getData(qur);
            cmbsophong.DataSource = ds.Tables[0];

        }
        private void NapCT1()
        {

            
        } 

            
        private void UserKhachHangDichVu_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();

            try
            {
                sql = "SELECT idphong" +
               " FROM hoadonphong" +
               " WHERE hoadonphong.idkh =" + int.Parse(Bientoancuc.saveIDKH) + " AND ngaycheckout IS NULL ";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt1);
                cmbsophong.DataSource = dt1;
                cmbsophong.DisplayMember = "idphong";


                sql = "SELECT * FROM dbo.dichvu";
                loadData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                 }
         

            //dt.Clear();
          // grddv.Refresh();
         
          // dt1.Clear();


            sl = Int16.Parse(txtsoluong.Text);
        }
    }
}
