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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
   
            //btnlichsu.FillColor = Color.Blue;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thông tin ";
            UserThongTin fc = new UserThongTin();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.Brown;
           // guna2ShadowPanel2.FillColor = Color.HotPink;
      
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Yellow;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;

            btnPhongdangthue.FillColor = Color.Blue;
  
            btnPhongDatTruoc.FillColor = Color.Blue;
           // guna2Button7.FillColor = Color.Blue;

            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            lbten.Text = "Dịch vụ";
            UserKhachHangDichVu fc = new UserKhachHangDichVu();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Yellow;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;
            btnPhongdangthue.FillColor = Color.Blue;
            btnPhongDatTruoc.FillColor = Color.Blue;
           // guna2Button7.FillColor = Color.Blue;
            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lbten.Text = "Phòng đang thuê";
            UserPhongDatTRuocKH fc = new UserPhongDatTRuocKH();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.Khaki;
            //guna2ShadowPanel2.FillColor = Color.LightGoldenrodYellow;
      
           
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;
         
            btnPhongdangthue.FillColor = Color.Yellow;
   
            btnPhongDatTruoc.FillColor = Color.Blue;
          //  guna2Button7.FillColor = Color.Blue;
      
            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UserKHNgonNgu fc = new UserKHNgonNgu();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.LightGray;
           // guna2ShadowPanel2.FillColor = Color.Navy;
            
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;
            //  userPhongDatTRuocKH1.Visible = false;
            btnPhongdangthue.FillColor = Color.Blue;
        
            btnPhongDatTruoc.FillColor = Color.Blue;
    
            btnlichsu.FillColor = Color.Blue;
            //    guna2Button7.FillColor = Color.Yellow;
            btnthongtinks.FillColor = Color.Blue;

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            lbten.Text = "Trả phòng";
            UserKhachHangTraPhong fc = new UserKhachHangTraPhong();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.PowderBlue;
            //guna2ShadowPanel2.FillColor = Color.Fuchsia;
        
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Yellow;
            btnPhongdangthue.FillColor = Color.Blue;

            btnPhongDatTruoc.FillColor = Color.Blue;
          //  guna2Button7.FillColor = Color.Blue;
      
            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lbten.Text = "Tài khoản";
            UserTaiKhoanKH fc = new UserTaiKhoanKH();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
           dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.PowderBlue;
            //guna2ShadowPanel2.FillColor = Color.Fuchsia;
            btnTaiKhoan.FillColor = Color.Yellow;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;
            btnPhongdangthue.FillColor = Color.Blue;
            btnPhongDatTruoc.FillColor = Color.Blue;
           // guna2Button7.FillColor = Color.Blue;
            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lbten.Text = "Thuê Phòng";
            UserKhachHangThuePhong fc = new UserKhachHangThuePhong();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.PowderBlue;
            //guna2ShadowPanel2.FillColor = Color.Fuchsia;
     
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Yellow;
            btnTraPhong.FillColor = Color.Blue;
     
            btnPhongdangthue.FillColor = Color.Blue;
       
            btnPhongDatTruoc.FillColor = Color.Blue;
           // guna2Button7.FillColor = Color.Blue;
            
            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void userKhThuePhong1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            lbten.Text = "Phòng đặt trước";
            UserKhachHangPhongThueTruoc1 fc = new UserKhachHangPhongThueTruoc1();
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            guna2ShadowPanel1.FillColor = Color.PowderBlue;
            //guna2ShadowPanel2.FillColor = Color.Fuchsia;
          
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;
          
            btnPhongdangthue.FillColor = Color.Blue;
     
            
            btnPhongDatTruoc.FillColor = Color.Yellow;
           // guna2Button7.FillColor = Color.Blue;
            
            btnlichsu.FillColor = Color.Blue;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void userKhachHangPhongThueTruoc11_Load(object sender, EventArgs e)
        {

        }

        private void btnlichsu_Click(object sender, EventArgs e)
        {
            lbten.Text = "Lịch sử";
            guna2ShadowPanel1.FillColor = Color.PowderBlue;
           // guna2ShadowPanel2.FillColor = Color.Fuchsia;
        
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;
           
            btnPhongdangthue.FillColor = Color.Blue;
       
            btnPhongDatTruoc.FillColor = Color.Blue;
           // guna2Button7.FillColor = Color.Blue;
        
            UserKhachHangLichSu fc = new UserKhachHangLichSu();
       
            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            btnlichsu.FillColor = Color.Yellow;
            btnthongtinks.FillColor = Color.Blue;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            lbten.Text = "Thông tin khách sạn";
            KHTHongtinKS fc = new KHTHongtinKS();

            dtgPanel1.Controls.Clear();
            // f.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            dtgPanel1.Controls.Add(fc);
            fc.Show();
            btnlichsu.FillColor = Color.Blue ;
            btnthongtinks.FillColor = Color.Yellow;
            btnTaiKhoan.FillColor = Color.Blue;
            btnDichVu.FillColor = Color.Blue;
            btnThongtin.FillColor = Color.Blue;
            btnThuePhong.FillColor = Color.Blue;
            btnTraPhong.FillColor = Color.Blue;

            btnPhongdangthue.FillColor = Color.Blue;

            btnPhongDatTruoc.FillColor = Color.Blue;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
