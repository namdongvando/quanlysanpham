using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class DanhMucTable:Common
    {

        protected List<DanhMuc> DanhMucs()
        {
            List<DanhMuc> ls = new List<DanhMuc>();
            SqlDataReader dataReder;
            string sql = "select * from Categories";
            dataReder = Query(sql);
            while (dataReder.Read())
            {
                DanhMuc sp = new DanhMuc(
                    dataReder.GetValue(0).ToString()
                   , dataReder.GetValue(1).ToString()
                   , dataReder.GetValue(2).ToString()
                   , dataReder.GetValue(3).ToString()
                    );

                ls.Add(sp);
            }
            return ls;
        }


    }
}
