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
    public class D_GV
    {
        public static DataTable getData()
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("gte_GV", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void InsertGV(tbGV GV)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_InsertGV", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenGV", SqlDbType.NVarChar, 30);
            com.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@Phone", SqlDbType.NVarChar, 15);
            com.Parameters.Add("@Email", SqlDbType.NVarChar, 20);
            com.Parameters.Add("@GiangDayMon", SqlDbType.NVarChar, 20);
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);

            com.Parameters["@MaGV"].Value = GV.MaGV1;
            com.Parameters["@TenGV"].Value = GV.TenGV1;
            com.Parameters["@GioiTinh"].Value = GV.GioiTinh1;
            com.Parameters["@Phone"].Value = GV.Phone1;
            com.Parameters["@Email"].Value = GV.Email1;
            com.Parameters["@GiangDayMon"].Value = GV.GiangDayMon1;
            com.Parameters["@MaLop"].Value = GV.MaLop1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void UpdateGV(tbGV GV)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_UpdateGV", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@TenGV", SqlDbType.NVarChar, 30);
            com.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            com.Parameters.Add("@Phone", SqlDbType.NVarChar, 15);
            com.Parameters.Add("@Email", SqlDbType.NVarChar, 20);
            com.Parameters.Add("@GiangDayMon", SqlDbType.NVarChar, 20);
            com.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10);

            com.Parameters["@MaGV"].Value = GV.MaGV1;
            com.Parameters["@TenGV"].Value = GV.TenGV1;
            com.Parameters["@GioiTinh"].Value = GV.GioiTinh1;
            com.Parameters["@Phone"].Value = GV.Phone1;
            com.Parameters["@Email"].Value = GV.Email1;
            com.Parameters["@GiangDayMon"].Value = GV.GiangDayMon1;
            com.Parameters["@MaLop"].Value = GV.MaLop1;

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
        public static void DelesttGV(string magv)
        {
            SqlConnection conn = dbConecction.ketnoi();
            SqlCommand com = new SqlCommand("sp_DelectGV", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@MaGV", SqlDbType.NVarChar, 10);

            com.Parameters["@MaGV"].Value = magv;


            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

    }
}
