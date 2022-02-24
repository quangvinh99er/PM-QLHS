using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class D_Timkiem
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
        public static DataTable timkiem(string chuoitimkiem)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_timkiem", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("MaHS", SqlDbType.NVarChar)).Value = chuoitimkiem;
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
