using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cuoiKy
{
    public class Bientoancuc
    {
        public static string TCconnstr = @"Data Source=VONHUY\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        public static string tenks;
        public static string tenchuks;
        public static string diachi;
        public static string sdt;
        public static string masothue;
        public static DateTime ngaythanhlap;
        public static string vitri;
        public static string logofile;
        public static string savetaikhoan;
        public static string savematkhau;
        public static string saveIDKH;
        public static string savehoten;
        public static string cmnd;
        public static int SaveEnglish;
        public static int saveLanguage;
        public static string savePhong;
        public static int saveIdHDPhong;
        public static int SaveIDHDP;
    }
    internal static class Program
    {
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DangNHapKS());
            Application.Run(new DangNHapKS());
        }
    }
}
