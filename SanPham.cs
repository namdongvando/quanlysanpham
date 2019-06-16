using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class SanPham : SanPhamTable
    {
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string SupplierID { set; get; }
        public string CategoryID { set; get; }
        public string QuantityPerUnit { set; get; }
        public string UnitPrice { set; get; }
        public string UnitsInStock { set; get; }
        public string UnitsOnOrder { set; get; }
        public string ReorderLevel { set; get; }
        public string Discontinued { set; get; }

        public SanPham(
                    string ProductID
                    , string ProductName
                    , string SupplierID
                    , string CategoryID
                    , string QuantityPerUnit
                    , string UnitPrice
                    , string UnitsInStock
                    , string UnitsOnOrder
                    , string ReorderLevel
                    , string Discontinued)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SupplierID = SupplierID;
            this.CategoryID = CategoryID;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;
            this.Discontinued = Discontinued;
        }

        public SanPham()
        {
        }

        public List<SanPham> DSSanPham() {
            return this.SanPhams();
        }
        public List<SanPham> getDSSanPhamTheoDanhMuc(string catid)
        {
            return this.DSSanPhamTheoDanhMuc(catid);
        }

        public void ThemSanPham(SanPham sp)
        {
            this.InsertSP(sp);
        }

        public List<SanPham> getDSSanPhamTheoTen(string Ten)
        {
            return this.DSSanPhamTheoTen(Ten);
        }

        public List<SanPham> getDSSanPhamTheoTen(string Ten, string dm) {
            return DSSanPhamTheoTen(Ten, dm);
        }
    }
}
