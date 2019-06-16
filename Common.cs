using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    class Common
    {
        protected static string connetionString = @"Data Source=DESKTOP-M2PUTJR;Initial Catalog=Northwind;Integrated Security=True";


        protected static SqlDataReader Query(string sql)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            //SqlDataReader dataReder;
            command = new SqlCommand(sql, cnn);
            return command.ExecuteReader();
            //dataReder = command.ExecuteReader();
            //dataReder.Close();
            //command.Dispose();
            //cnn.Close();
            //return dataReder;

        }

    }
}
