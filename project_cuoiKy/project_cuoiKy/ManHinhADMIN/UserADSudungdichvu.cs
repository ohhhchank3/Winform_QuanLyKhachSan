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
    public partial class UserADSudungdichvu : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        function fn = new function();
        DataTable dt1 = new DataTable();
        string sql, connstr, timkiem;
        int i, sl;
        private static UserADSudungdichvu _instance;
        public static UserADSudungdichvu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserADSudungdichvu();

                }
                return _instance;
            }
        }
        private void btngiamsl_Click(object sender, EventArgs e)
        {
            if (sl > 0)
            {
                sl--;
                txtsoluong.Text = sl.ToString();
            }
        }

        private void txttiemkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Nhập tên dịch vụ";
                txttimkiem.ForeColor = Color.DarkGray;
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập tên dịch vụ")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }
        public void NapCT()
        {
            i = grddv.CurrentRow.Index;
            txttendv.Text = grddv[0, i].Value.ToString();
            txtgiadv.Text = grddv[2, i].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập tên dịch vụ") timkiem = "";
            else timkiem = txttimkiem.Text;
            sql = "SELECT * FROM dbo.dichvu WHERE tendv LIKE N'%" + timkiem + "%'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddv.DataSource = dt;
            grddv.Refresh();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string sophongdv = cmbsophong.Text;
            if (txttendv.Text != "" && cmbsophong.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    string ngaygoi = dtpngaygoi.Value.ToString("yyyy-MM-dd");
                    sql = "INSERT INTO dbo.hoadondv( idhdp, tendv, ngaygoi, soluong )VALUES"
                         + "((SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" + cmbsophong.Text + "' AND ngaycheckout IS NULL),N'" + txttendv.Text + "','" + ngaygoi + "','" + txtsoluong.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    String k = "UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv * hoadondv.soluong) from hoadondv, dichvu where dichvu.tendv = hoadondv.tendv and hoadondv.idhdp = (SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" + cmbsophong.Text + "' AND ngaycheckout IS NULL) ) where hoadonphong.idhdp = (SELECT idhdp FROM dbo.hoadonphong WHERE idphong = '" +cmbsophong.Text + "' AND ngaycheckout IS NULL) ";
                    fn.setData(k);
                    MessageBox.Show("Thực hiện thêm thành công");
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            grddv.CurrentCell = grddv[0, 0];
            NapCT();
        }

        private void btnxuong_Click(object sender, EventArgs e)
        {
            i = grddv.CurrentRow.Index;
            if (i < grddv.Rows.Count - 1)
            {
                grddv.CurrentCell = grddv[0, i + 1];
                NapCT();
            }
        }

        private void btnlen_Click(object sender, EventArgs e)
        {
            i = grddv.CurrentRow.Index;
            if (i != 0)
            {
                grddv.CurrentCell = grddv[0, i - 1];
                NapCT();
            }
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            grddv.CurrentCell = grddv[0, grddv.Rows.Count - 2];
            NapCT();
        }

        private void btntangsl_Click(object sender, EventArgs e)
        {
            sl++;
            txtsoluong.Text = sl.ToString();
        }

        public UserADSudungdichvu()
        {
            InitializeComponent();
        }

        private void UserADSudungdichvu_Load(object sender, EventArgs e)
        {
            dtpngaygoi.MaxDate = DateTime.Now;

            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "SELECT * FROM dbo.dichvu";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grddv.DataSource = dt;
            grddv.Refresh();
            txtsoluong.Text = "1";



            sql = "SELECT idphong FROM dbo.phong WHERE trangthai = N'Có người'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt1);
            cmbsophong.DataSource = dt1;
            cmbsophong.DisplayMember = "idphong";


          //  sl = (txtsoluong.Text);
        }
    }
}
