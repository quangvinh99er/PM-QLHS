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
    public class D_Diem
    {
        public static DataTable getData()
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_DIEM", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertDIEM(tbDiem DIEM)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_InsertDIEM", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaMon", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenMon", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@DiemTb", SqlDbType.NVarChar, 5);
           

            com.Parameters["@MaMon"].Value = DIEM.MaMon1;
            com.Parameters["@TenMon"].Value = DIEM.TenMon1;
            com.Parameters["@MaHS"].Value = DIEM.MaHS1;
            com.Parameters["@HoTen"].Value = DIEM.HoTen1;
            com.Parameters["@DiemTb"].Value = DIEM.DiemTb1;
            

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateDIEM(tbDiem DIEM)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_UpdateDIEM", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaMon", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenMon", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@DiemTb", SqlDbType.NVarChar, 5);


            com.Parameters["@MaMon"].Value = DIEM.MaMon1;
            com.Parameters["@TenMon"].Value = DIEM.TenMon1;
            com.Parameters["@MaHS"].Value = DIEM.MaHS1;
            com.Parameters["@HoTen"].Value = DIEM.HoTen1;
            com.Parameters["@DiemTb"].Value = DIEM.DiemTb1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void DelesttDIEM(string DIEM)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_DelectDIEM", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaMon", SqlDbType.NVarChar, 10);

            com.Parameters["@MaMon"].Value = DIEM;


            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
