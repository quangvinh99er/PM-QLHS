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
     public class B_Lop
    {
        public static DataTable GetAllLOP()
        {
            return D_Lop.getDataLOP();
        }
        public static void InserLOP(tbLop LOP)
        {
            D_Lop.InsertLOP(LOP);
        }
        public static void UpdateLOP(tbLop LOP)
        {
            D_Lop.UpdateLOP(LOP);
        }
        public static void DeleteLOP(string LOP)
        {
            D_Lop.DelesttLOP(LOP);
        }
    }
}
