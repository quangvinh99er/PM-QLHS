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
    public class D_Hocsinh
    {
        public static DataTable getData()
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_HS", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertHS(tbHocsinh hs)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_InsertHocsinh", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@NgaySinh", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5);
            com.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            com.Parameters["@MaHS"].Value = hs.MaHS1;
            com.Parameters["@HoTen"].Value = hs.HoTen1;
            com.Parameters["@NgaySinh"].Value = hs.NgaySinh1;
            com.Parameters["@GioiTinh"].Value = hs.GioiTinh1;
            com.Parameters["@DiaChi"].Value = hs.DiaChi1;
            com.Parameters["@MaLop"].Value = hs.MaLop1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateHS(tbHocsinh hs)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_UpdateHS", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@NgaySinh", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5);
            com.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);
            com.Parameters["@MaHS"].Value = hs.MaHS1;
            com.Parameters["@HoTen"].Value = hs.HoTen1;
            com.Parameters["@NgaySinh"].Value = hs.NgaySinh1;
            com.Parameters["@GioiTinh"].Value = hs.GioiTinh1;
            com.Parameters["@DiaChi"].Value = hs.DiaChi1;
            com.Parameters["@MaLop"].Value = hs.MaLop1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void DelesttHS(string mahs)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_DelectHS", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaHS", SqlDbType.NVarChar, 10);
           
            com.Parameters["@MaHS"].Value = mahs; 
         

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
