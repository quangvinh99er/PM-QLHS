using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class D_Lop
    {
        public static DataTable getDataLOP()
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_LOP", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertLOP(tbLop LOP)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_InsertLOP", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50);

            com.Parameters["@MaLop"].Value = LOP.MaLop1;
            com.Parameters["@TenLop"].Value = LOP.TenLop1;
            com.Parameters["@MaGV"].Value = LOP.MaGV1;
            com.Parameters["@MaHS"].Value = LOP.MaHS1;


            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateLOP(tbLop LOP)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_UpdateLOP", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50);

            com.Parameters["@MaLop"].Value = LOP.MaLop1;
            com.Parameters["@TenLop"].Value = LOP.TenLop1;
            com.Parameters["@MaGV"].Value = LOP.MaGV1;
            com.Parameters["@MaHS"].Value = LOP.MaHS1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void DelesttLOP(string LOP)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_DelectLOP", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);

            com.Parameters["@MaLop"].Value = LOP;


            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
