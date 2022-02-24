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
    public class B_SumScroes
    {
        public static DataTable GetAllload()
        {
            return D_SumScroes.getData();
        }
        }
}
