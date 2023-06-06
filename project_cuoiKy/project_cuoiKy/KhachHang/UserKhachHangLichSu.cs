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
    public partial class UserKhachHangLichSu : UserControl
    {
        function fn = new function();
        public UserKhachHangLichSu()
        {
            InitializeComponent();
        }
        public void loadData(string qur)
        {


            DataSet ds = fn.getData(qur);
            grdlichsuphong.DataSource = ds.Tables[0];

        }
        public void loadData1(string qur)
        {


            DataSet ds1 = fn.getData(qur);
            grddv.DataSource = ds1.Tables[0];

        }
        private void UserKhachHangLichSu_Load(object sender, EventArgs e)
        {
            try
            {
                 string queei = "select idhdp,idphong,ngaycheckin,ngaycheckout,tongtien,tienphong,tiendichvu from hoadonphong where ngaycheckout is not null and idkh = " + int.Parse(Bientoancuc.saveIDKH) + " ";
                loadData(queei);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string queei1 = "select * from hoadondv where idhdp = " + int.Parse(txtPhong.Text) + "";
                loadData1(queei1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void grdlichsuphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string stt = grdlichsuphong.Rows[e.RowIndex].Cells[0].Value.ToString();
            string queei12 = "select * from hoadondv where idhdp = " + int.Parse(stt.ToString()) + "";
            loadData1(queei12);
        }
    }
}
