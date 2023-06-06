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
    public partial class UserADDichVu : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtcmb = new DataTable();
        DataTable dtkt = new DataTable();
        string sql, connstr;
        String tdonvi, tgiadv;
        bool flag = false;
        int i;
        public UserADDichVu()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời", "Yêu cầu xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from dbo.dichvu where tendv='" + txttendv.Text + "'";
                grddmdv.Rows.RemoveAt(grddmdv.CurrentRow.Index); // Xóa dòng hiện thời của ô lười
                cmd = new SqlCommand(sql, conn); // khai báo 1 câu lệnh sql chuẩn bị thực hiện
                cmd.ExecuteNonQuery();
                //da = new SqlDataAdapter(sql,conn);
                //dt.Clear();
                //da.Fill(dt);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            btncapnhat.Enabled = true;
            flag = false;
            txtgiadv.Enabled = true;
            txtdonvitinh.Enabled = true;
            txtgiadv.Focus();
            btnthem.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            //txtdonvi.Enabled = false;
            //txtgiadv.Enabled = false;
            txtgiadv.Focus();
            sql = " Update dbo.dichvu set donvi=N'" + txtdonvitinh.Text + "',giadv='" + float.Parse(txtgiadv.Text) +
                "' where tendv=N'" + txttendv.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();


            //Cập nhật lại dữ liệu bảng
            sql = "select * from dbo.dichvu";
            da = new SqlDataAdapter(sql, conn); // thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt
            grddmdv.DataSource = dt; //khai báo nguồn dữ liệu của ô lưới 
            grddmdv.Refresh();
            NapCT();

            MessageBox.Show("Đã cập nhật thành công", "Thông báo");
            //  btncapnhat.Enabled = false;
            // btnthem.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
         
                sql = "select * from dbo.dichvu where tendv=N'" + txttendv.Text + "'";
                da = new SqlDataAdapter(sql, conn); // thực hiện câu lệnh truy vấn csdl
                dtkt.Clear();
                da.Fill(dtkt);
                if (dtkt.Rows.Count == 0 && txttendv.Text != "")
                {
                   string sq3 = "insert into dbo.dichvu(tendv,donvi,giadv) values (N'" + txttendv.Text + "',N'" + txtdonvitinh.Text+ "','" + Convert.ToInt64(txtgiadv.Text)+ "')";
                    cmd = new SqlCommand(sq3, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");

                    sql = "select * from dbo.dichvu";
                    da = new SqlDataAdapter(sql, conn); // thực hiện câu lệnh truy vấn csdl
                    dt.Clear();
                    da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt
                    grddmdv.DataSource = dt; //khai báo nguồn dữ liệu của ô lưới 
                    grddmdv.Refresh();
                    NapCT();
                }
                else
                {
                    MessageBox.Show("Tên dịch vụ bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttendv.Text = "";
                }

           
        }
            private void guna2Button8_Click(object sender, EventArgs e)
        {
            i = grddmdv.CurrentRow.Index;
            if (i < grddmdv.Rows.Count - 1)
            {
                grddmdv.CurrentCell = grddmdv[0, i + 1];
                NapCT();
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            i = grddmdv.CurrentRow.Index;
            if (i != 0)
            {
                grddmdv.CurrentCell = grddmdv[0, i - 1];
                NapCT();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            grddmdv.CurrentCell = grddmdv[0, 0];
            NapCT();
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            grddmdv.CurrentCell = grddmdv[0, grddmdv.Rows.Count - 2];
            NapCT();
        }

        private void grddmdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sql = "select * from dbo.dichvu where tendv=N'" + txttendv.Text + "'";
            da = new SqlDataAdapter(sql, conn); // thực hiện câu lệnh truy vấn csdl
            dtkt.Clear();
            da.Fill(dtkt);
            if (dtkt.Rows.Count == 0 && txttendv.Text != "")
            {
                sql = "Insert into dbo.dichvu values (N'" + txttendv.Text + "',N'" + txtgiadv.Text + "','" + txtdonvitinh.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");

                sql = "select * from dbo.dichvu";
                da = new SqlDataAdapter(sql, conn); // thực hiện câu lệnh truy vấn csdl
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt
                grddmdv.DataSource = dt; //khai báo nguồn dữ liệu của ô lưới 
                grddmdv.Refresh();
                NapCT();
            }
            else
            {
                MessageBox.Show("Tên dịch vụ bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttendv.Text = "";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi hiện thời", "Yêu cầu xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from dbo.dichvu where tendv='" + txttendv.Text + "'";
                grddmdv.Rows.RemoveAt(grddmdv.CurrentRow.Index); // Xóa dòng hiện thời của ô lười
                cmd = new SqlCommand(sql, conn); // khai báo 1 câu lệnh sql chuẩn bị thực hiện
                cmd.ExecuteNonQuery();
                //da = new SqlDataAdapter(sql,conn);
                //dt.Clear();
                //da.Fill(dt);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtgiadv.Focus();
            sql = " Update dbo.dichvu set donvi=N'" + txtgiadv.Text + "',giadv='" + txtdonvitinh.Text +
                "' where tendv=N'" + txttendv.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();


            //Cập nhật lại dữ liệu bảng
            sql = "select * from dbo.dichvu";
            da = new SqlDataAdapter(sql, conn); // thực hiện câu lệnh truy vấn csdl
            dt.Clear();
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt
            grddmdv.DataSource = dt; //khai báo nguồn dữ liệu của ô lưới 
            grddmdv.Refresh();
            NapCT();

            MessageBox.Show("Đã cập nhật thành công", "Thông báo");
        }

        private void grddmdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserADDichVu_Load(object sender, EventArgs e)
        {
            connstr = Bientoancuc.TCconnstr;
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "Select * from dbo.dichvu";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddmdv.DataSource = dt;
            grddmdv.Refresh();
        }
       public void NapCT()
        {
            i = grddmdv.CurrentRow.Index;
            txttendv.Text = grddmdv[0, i].Value.ToString();
            txtgiadv.Text = grddmdv[2, i].Value.ToString();
            txtdonvitinh.Text = grddmdv[1, i].Value.ToString();
        }
    }
}
