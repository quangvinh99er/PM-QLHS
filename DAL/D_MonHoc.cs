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
    public class D_MonHoc
    {
        public static DataTable getDataMH()
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_MH", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertMH(tbMonhoc mh)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_Insertmonhoc", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaMon", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenMon", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50);
           
            com.Parameters["@MaMon"].Value = mh.MaMon1;
            com.Parameters["@TenMon"].Value = mh.TenMon1;
            com.Parameters["@MaGV"].Value = mh.MaGV1;
            com.Parameters["@MaHS"].Value = mh.MaHS1;
            

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateMH(tbMonhoc mh)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_UpdateMH", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaMon", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenMon", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 50);

            com.Parameters["@MaMon"].Value = mh.MaMon1;
            com.Parameters["@TenMon"].Value = mh.TenMon1;
            com.Parameters["@MaGV"].Value = mh.MaGV1;
            com.Parameters["@MaHS"].Value = mh.MaHS1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void DelesttMH(string mamon)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_DelectMH", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaMon", SqlDbType.NVarChar, 10);

            com.Parameters["@MaMon"].Value = mamon;


            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
