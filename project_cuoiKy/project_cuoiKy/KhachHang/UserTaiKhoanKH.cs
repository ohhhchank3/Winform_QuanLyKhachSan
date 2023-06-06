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
    public partial class UserTaiKhoanKH : UserControl
    {
        function fn = new function();
       // function fn = new function();
        public UserTaiKhoanKH()
        {
            InitializeComponent();
        }
  

        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            guna2DataGridView1.DataSource = ds.Tables[0];



        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {

            try
            {
                String queei = "select * from TAIKHOAN where TaiKhoan = N'" + Bientoancuc.savetaikhoan + "'";
                String up = " update dbo.TAIKHOAN set MatKhau =N'" + txtMK.Text + "'" +
             "where TaiKhoan = N'" + txtTK.Text + "'";
                fn.setData(up);
                loadData(queei);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "delete from TAIKHOAN where TaiKhoan = N'" + txtTK.Text + "'";
                fn.setData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                // Bientoancuc.saveIDKH = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UserTaiKhoanKH_Load(object sender, EventArgs e)
        {
            String queei = "select * from TAIKHOAN where TaiKhoan = N'" + Bientoancuc.savetaikhoan + "'";
            txtId.Text = Bientoancuc.saveIDKH;
            txtTK.Text = Bientoancuc.savetaikhoan;
            txtMK.Text = Bientoancuc.savematkhau;
            txtTK.Enabled = false;
            txtId.Enabled = false;


            loadData(queei);
        }
    }
}
