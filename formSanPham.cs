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
    public partial class formSanPham : Form
    {
        public formSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private SanPham inputForm()
        {
            double up = 0, UnitsInStock, UnitsOnOrder, ReorderLevel, QuantityPerUnit;
            double.TryParse(txtUnitPrice.Text, out up);
            double.TryParse(txtUnitPrice.Text, out UnitsInStock);
            double.TryParse(txtUnitPrice.Text, out UnitsOnOrder);
            double.TryParse(txtUnitPrice.Text, out ReorderLevel);
            double.TryParse(txtUnitPrice.Text, out QuantityPerUnit);
            string ProductName = txtProductName.Text;
            string SupplierID = txtSupplierID.Text;
            string Discontinued = true.ToString();
            DanhMuc dm = (DanhMuc) cbbDanhMuc.SelectedItem;

            return new SanPham(null, ProductName,"1",
                dm.CategoryID,QuantityPerUnit.ToString(),up.ToString(),
                UnitsInStock.ToString(),UnitsOnOrder.ToString(),
                ReorderLevel.ToString(),true.ToString());
        }

        private void formSanPham_Load(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            cbbDanhMuc.DataSource = dm.DSDanhMuc();
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.ValueMember = "CategoryID";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham Sp = this.inputForm();
            Sp.ThemSanPham(Sp);
            MessageBox.Show("Them Thang Cong");
        }
    }
}
