using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có muốn thoát không","Cảnh Báo!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (kt == DialogResult.Yes) {
                this.Close();
            }


        }

        private void quanlySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void danhSáchSảnPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSSanPham fsp = new formDSSanPham();
            fsp.MdiParent = this;
            fsp.Show();
        }

        private void themSanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSanPham fsp = new formSanPham();
            fsp.MdiParent = this;
            fsp.Show();
        }
    }
}
