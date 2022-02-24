using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Search
    {
        public static DataTable getData()
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_dtSearch", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable search(string chuoitimkiem)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_timkiem", conn);
            com.CommandType = CommandType.StoredProcedure;
            
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }



    }
}
