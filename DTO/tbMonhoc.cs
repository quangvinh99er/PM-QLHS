using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class tbMonhoc
    {
        string MaMon;
        string TenMon;
        string MaGV;
        string MaHS;

        public tbMonhoc(string maMon, string tenMon, string maGV, string maHS)
        {
            MaMon = maMon;
            TenMon = tenMon;
            MaGV = maGV;
            MaHS = maHS;
        }

        public string MaMon1
        {
            get
            {
                return MaMon;
            }

            set
            {
                MaMon = value;
            }
        }

        public string TenMon1
        {
            get
            {
                return TenMon;
            }

            set
            {
                TenMon = value;
            }
        }

        public string MaGV1
        {
            get
            {
                return MaGV;
            }

            set
            {
                MaGV = value;
            }
        }

        public string MaHS1
        {
            get
            {
                return MaHS;
            }

            set
            {
                MaHS = value;
            }
        }
    }
}
