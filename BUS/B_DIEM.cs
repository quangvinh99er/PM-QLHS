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
    public class B_DIEM
    {
        public static DataTable GetAllDIEM()
        {
            return D_Diem.getData();
        }
        public static void InserDIEM(tbDiem DIEM)
        {
            D_Diem.InsertDIEM(DIEM);
        }
        public static void UpdateDIEM(tbDiem DIEM)
        {
            D_Diem.UpdateDIEM(DIEM);
        }
        public static void DeleteDIEM(string DIEM)
        {
            D_Diem.DelesttDIEM(DIEM);
        }
    }
}
