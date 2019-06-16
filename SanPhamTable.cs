using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class SanPhamTable : Common
    {


        public SanPhamTable()
        {
        }



        protected List<SanPham> SanPhams()
        {
            List<SanPham> ls = new List<SanPham>();
            SqlDataReader dataReder;
            string sql = "select * from Products";
            dataReder = Query(sql);
            while (dataReder.Read())
            {
                SanPham sp = new SanPham(
                    dataReder.GetValue(0).ToString()
                   , dataReder.GetValue(1).ToString()
                   , dataReder.GetValue(2).ToString()
                   , dataReder.GetValue(3).ToString()
                   , dataReder.GetValue(4).ToString()
                   , dataReder.GetValue(5).ToString()
                   , dataReder.GetValue(6).ToString()
                   , dataReder.GetValue(7).ToString()
                   , dataReder.GetValue(8).ToString()
                   , dataReder.GetValue(9).ToString()
                    );

                ls.Add(sp);
            }
            return ls;
        }

        public void test()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReder;
            string sql = "select * from Products";
            command = new SqlCommand(sql, cnn);
            dataReder = command.ExecuteReader();
            string output = "";
            while (dataReder.Read())
            {
                output = output + dataReder.GetValue(0);
            }
            dataReder.Close();
            command.Dispose();
            cnn.Close();
        }

        protected List<SanPham> DSSanPhamTheoDanhMuc(string catid)
        {
            List<SanPham> ls = new List<SanPham>();

            SqlDataReader dataReder;
            string sql = "select * from Products where CategoryID =" + catid;
            dataReder = Query(sql);
            while (dataReder.Read())
            {
                SanPham sp = new SanPham(
                    dataReder.GetValue(0).ToString()
                   , dataReder.GetValue(1).ToString()
                   , dataReder.GetValue(2).ToString()
                   , dataReder.GetValue(3).ToString()
                   , dataReder.GetValue(4).ToString()
                   , dataReder.GetValue(5).ToString()
                   , dataReder.GetValue(6).ToString()
                   , dataReder.GetValue(7).ToString()
                   , dataReder.GetValue(8).ToString()
                   , dataReder.GetValue(9).ToString()
                    );
                ls.Add(sp);
            }
            return ls;
        }

        protected void InsertSP(SanPham sp) {
            string sql = String.Format(@"insert into Products 
(ProductName , SupplierID , CategoryID , QuantityPerUnit , UnitPrice , UnitsInStock , UnitsOnOrder
, ReorderLevel
, Discontinued)
Values( '{0}' , '{1}' , '{2}' , '{3}' , '{4}' , '{5}' , '{6}' , '{7}' , '0')"
,sp.ProductName
,sp.SupplierID
,sp.CategoryID
,sp.QuantityPerUnit
,sp.UnitPrice
,sp.UnitsInStock
,sp.UnitsOnOrder
,sp.ReorderLevel);
            Query(sql);
        }
        protected void DeleteSP(String spid)
        {
            string sql = String.Format(@"delete Products where ProductID = '{0}'", spid);
            Query(sql);
        }
        protected List<SanPham> DSSanPhamTheoTen(string ten, string dm)
        {
            List<SanPham> ls = new List<SanPham>();

            SqlDataReader dataReder;
            //string sql = @"select * from Products where ProductName like '%"+ ten + "%'";
            string sql = "select * from Products where ProductName like '%" 
                + ten + "%' and CategoryID = " + dm;
            dataReder = Query(sql);
            while (dataReder.Read())
            {
                SanPham sp = new SanPham(
                    dataReder.GetValue(0).ToString()
                   , dataReder.GetValue(1).ToString()
                   , dataReder.GetValue(2).ToString()
                   , dataReder.GetValue(3).ToString()
                   , dataReder.GetValue(4).ToString()
                   , dataReder.GetValue(5).ToString()
                   , dataReder.GetValue(6).ToString()
                   , dataReder.GetValue(7).ToString()
                   , dataReder.GetValue(8).ToString()
                   , dataReder.GetValue(9).ToString()
                    );
                ls.Add(sp);
            }
            return ls;
        }

        protected List<SanPham> DSSanPhamTheoTen(string ten)
        {
            List<SanPham> ls = new List<SanPham>();

            SqlDataReader dataReder;
            //string sql = @"select * from Products where ProductName like '%"+ ten + "%'";
            string sql = "select * from Products where ProductName like '%" + ten + "%'";
            dataReder = Query(sql);
            while (dataReder.Read())
            {
                SanPham sp = new SanPham(
                    dataReder.GetValue(0).ToString()
                   , dataReder.GetValue(1).ToString()
                   , dataReder.GetValue(2).ToString()
                   , dataReder.GetValue(3).ToString()
                   , dataReder.GetValue(4).ToString()
                   , dataReder.GetValue(5).ToString()
                   , dataReder.GetValue(6).ToString()
                   , dataReder.GetValue(7).ToString()
                   , dataReder.GetValue(8).ToString()
                   , dataReder.GetValue(9).ToString()
                    );
                ls.Add(sp);
            }
            return ls;
        }

    }
}
