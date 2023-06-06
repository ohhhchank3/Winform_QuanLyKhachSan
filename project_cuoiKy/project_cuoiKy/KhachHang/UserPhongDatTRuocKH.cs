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
    public partial class UserPhongDatTRuocKH : UserControl
    {
        function fn = new function();

        public UserPhongDatTRuocKH()
        {
            InitializeComponent();
        }
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
           grdphong.DataSource = ds.Tables[0];

        }
        private void UserPhongDatTRuocKH_Load(object sender, EventArgs e)
        {
            try
            {
                String sql1 = "SELECT phong.idphong, hoten, ngaycheckin, cmnd,phong.trangthai " +
           "FROM dbo.hoadonphong,dbo.khachhang,phong " 
          + "WHERE hoadonphong.idkh = khachhang.idkh AND phong.idphong = hoadonphong.idphong  and phong.trangthai = N'Có người' and ngaycheckout IS NULL and khachhang.idkh= " + int.Parse(Bientoancuc.saveIDKH.ToString()) + "" +
           " ORDER BY idphong ASC";
                loadData(sql1);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
