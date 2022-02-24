using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbLop
    {
        string MaLop;
        string TenLop;
        string MaGV;
        string MaHS;

        public tbLop(string maLop, string tenLop, string maGV, string maHS)
        {
            MaLop = maLop;
            TenLop = tenLop;
            MaGV = maGV;
            MaHS = maHS;
        }

        public string MaLop1
        {
            get
            {
                return MaLop;
            }

            set
            {
                MaLop = value;
            }
        }

        public string TenLop1
        {
            get
            {
                return TenLop;
            }

            set
            {
                TenLop = value;
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
