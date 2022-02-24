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
   public class B_Monhoc
    {
        public static DataTable GetAllMH()
        {
            return D_MonHoc.getDataMH();
        }
        public static void InserMH(tbMonhoc mh)
        {
            D_MonHoc.InsertMH(mh);
        }
        public static void UpdateMH(tbMonhoc mh)
        {
            D_MonHoc.UpdateMH(mh);
        }
        public static void DeleteMH(string mamon)
        {
            D_MonHoc.DelesttMH(mamon);
        }
    }
}
