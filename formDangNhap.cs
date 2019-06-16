using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string u = txtTaiKhoan.Text;
            string p = txtMatKhau.Text;
            Users user = new Users();
            Users CurrentUser = user.CheckLogin(u, p);
            if (CurrentUser.Username == null) {
                lblThongBao.Text = "Đang nhập không thàng công";
                return;
            }
            user.setCurrnetUser(CurrentUser);
            this.Close();
        }
    }
}
