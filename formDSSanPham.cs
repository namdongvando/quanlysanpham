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
    public partial class formDSSanPham : Form
    {
        public formDSSanPham()
        {
            InitializeComponent();
        }

        private void formDSSanPham_Load(object sender, EventArgs e)
        {

            DanhMuc dm = new DanhMuc();
            cbbDanhMuc.DataSource = dm.DSDanhMuc();
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.ValueMember = "CategoryId";
            // load dang sách san pham 
            SanPham sp = new SanPham();
            //dgvSanPham.DataSource = sp.DSSanPham();
           dgvSanPham.DataSource = sp.getDSSanPhamTheoDanhMuc("8");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhMuc dm = (DanhMuc)cbbDanhMuc.SelectedItem;
            SanPham sp = new SanPham();
            dgvSanPham.DataSource = sp.getDSSanPhamTheoDanhMuc(dm.CategoryID);
            dgvSanPham.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DanhMuc dm = (DanhMuc)cbbDanhMuc.SelectedItem;
            SanPham sp = new SanPham();
            dgvSanPham.DataSource = sp.getDSSanPhamTheoTen(txtTukhoa.Text,dm.CategoryID);
            dgvSanPham.Refresh();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            formSuaSanPham fsps = new formSuaSanPham();
            try
            {
                fsps.FormSuaSanPham(new SanPham());
                fsps.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            

        }
    }
}
