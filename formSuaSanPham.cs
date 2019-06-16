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
    public partial class formSuaSanPham : Form
    {
        public formSuaSanPham()
        {
            InitializeComponent();
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Bạn có muốn thoát không", "thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (kt == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.XoaSanPham(txtProductID.Text);

        }

        private void FormSuaSanPham(SanPham sp)
        {
            txtProductID.Text = sp.ProductID.ToString();
            txtProductName.Text = sp.ProductID.ToString();
            txtSupplierID.Text = sp.ProductID.ToString();
            cbbDanhMuc.SelectedIndex = int.Parse(sp.CategoryID);
            txtQuantityPerUnit.Text = sp.QuantityPerUnit.ToString();
            txtUnitPrice.Text = sp.UnitPrice.ToString();
            txtUnitsInStock.Text = sp.UnitsInStock.ToString();
            txtUnitsOnOrder.Text = sp.UnitsOnOrder.ToString();
            txtReorderLevel.Text = sp.ReorderLevel.ToString();
            txtDiscontinued.Text = sp.Discontinued.ToString();
        }
    }
}
