using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class B_Hocsinh
    {
        public static DataTable GetAllHS()
        {
            return D_Hocsinh.getData();
        }
        public static void InserHS(tbHocsinh hs)
        {
            D_Hocsinh.InsertHS(hs);
        }
        public static void UpdateHS(tbHocsinh hs)
        {
            D_Hocsinh.UpdateHS(hs);
        }
        public static void DeleteHS(string mahs)
        {
            D_Hocsinh.DelesttHS(mahs);
        }
    }
}
