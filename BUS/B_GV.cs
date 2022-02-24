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
   public class B_GV
    {
        public static DataTable GetAllGV()
        {
            return D_GV.getData();
        }
        public static void InserGV(tbGV GV)
        {
            D_GV.InsertGV(GV);
        }
        public static void UpdateGV(tbGV GV)
        {
            D_GV.UpdateGV(GV);
        }
        public static void DeleteGV(string magv)
        {
            D_GV.DelesttGV(magv);
        }
    }
}
