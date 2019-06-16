using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //return;
            Application.Run(new formDangNhap());
            Users u = new Users();
            Users CurrnetUser =  u.getCurrnetUser();
            if (CurrnetUser.Username != null) {
                Application.Run(new Form1());
            }
            
        }
    }
}
