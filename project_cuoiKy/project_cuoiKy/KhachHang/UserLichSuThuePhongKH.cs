using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cuoiKy
{
    public partial class UserLichSuThuePhongKH : UserControl
    {
        function fn = new function();
        public UserLichSuThuePhongKH()
        {
            InitializeComponent();
        }
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
           grdlichsuphong.DataSource = ds.Tables[0];

        }
        private void UserLichSuThuePhongKH_Load(object sender, EventArgs e)
        {
           // String queei = "select * from hoadonphong where ngaycheckout is not null and idkh = " + int.Parse(Bientoancuc.saveIDKH) + " ";
            //loadData(queei);

        }

        private void grdlichsuphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string stt = grdlichsuphong.Rows[e.RowIndex].Cells[0].Value.ToString();
            string queei12 = "select * from hoadondv where idhdp = " + int.Parse(stt.ToString()) + "";
            //loadData1(queei12);
        }
    }
}
