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
    public partial class UserADDoimatKhauNhanVien : UserControl
    {
        function fn = new function();
        public UserADDoimatKhauNhanVien()
        {
            InitializeComponent();
        }

        private void txtNLMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserADDoimatKhauNhanVien_Load(object sender, EventArgs e)
        {
            txtTK.Text = Bientoancuc.savetaikhoan;
            txtMKCu.Text = Bientoancuc.savematkhau;
            txtTK.Enabled = false;
            txtMKCu.Enabled = false;

        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            if(txtMK.Text.ToString() == txtNLMK.Text.ToString())
            {
                String sql = "update dangnhap set mk = '" + txtMK.Text + "' where tdn = '" + Bientoancuc.savetaikhoan.ToString() + "'";
                fn.setData(sql);
                MessageBox.Show("Thực thiện thao tác đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.Text = txtMK.Text;
                txtMK.Text = "";
                txtNLMK.Text = "";
            }   
            else
            {
                Console.WriteLine("Mật khẩu nhập không khớp với mật khẩu nhập lại ");
            }    
        }
    }
}
