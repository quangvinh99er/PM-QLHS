using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DAL
{
    public class dbConecction
    {
        public static SqlConnection ketnoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-THTB7M5\SQLEXPRESS;Initial Catalog=QLHSPT;Integrated Security=True");
            return con;
        }
    }
}
