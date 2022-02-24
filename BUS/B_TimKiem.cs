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
    public class B_TimKiem
    {
        public static DataTable GetAllDS()
        {
            return D_Timkiem.getData();
        }
        
    }
}
