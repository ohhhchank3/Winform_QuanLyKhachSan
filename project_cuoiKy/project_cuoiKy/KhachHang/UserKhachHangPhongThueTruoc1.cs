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
    public partial class UserKhachHangPhongThueTruoc1 : UserControl
    {
        function fn = new function();
        public UserKhachHangPhongThueTruoc1()
        {
            InitializeComponent();
        }
        public void loadData(String qur)
        {


            DataSet ds = fn.getData(qur);
            grdPhong.DataSource = ds.Tables[0];

        }
        private void UserKhachHangPhongThueTruoc1_Load(object sender, EventArgs e)
        {
            try
            {
                //   String sql2 = "update phong " +
                //"set phong.trangthai = N'Có người' " +
                //"where phong.idphong in (select phong.idphong from hoadonphong,phong where phong.idphong = hoadonphong.idphong  and ngaycheckout is null and phong.trangthai = N' đặt trước' and(DAY(GETDATE()) - DAY(ngaycheckin) = 0))";
                // fn.setData(sql2);

                String sql1 = "SELECT idphong,idkh,ngaycheckin,SoTT,[check] " +
           " FROM dbo.PhongDatTruoc1 "
          + " WHERE PhongDatTruoc1.idkh = " + int.Parse(Bientoancuc.saveIDKH.ToString()) + " and [check] = 1 ORDER BY idphong ASC ";
                loadData(sql1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
