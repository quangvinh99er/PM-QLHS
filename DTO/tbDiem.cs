using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbDiem
    {
        string MaMon;
        string TenMon;
        string MaHS;
        string HoTen;
        string DiemTb;

        public tbDiem(string maMon, string tenMon, string maHS, string hoTen, string diemTb)
        {
            MaMon = maMon;
            TenMon = tenMon;
            MaHS = maHS;
            HoTen = hoTen;
            DiemTb = diemTb;
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

        public string HoTen1
        {
            get
            {
                return HoTen;
            }

            set
            {
                HoTen = value;
            }
        }

        public string DiemTb1
        {
            get
            {
                return DiemTb;
            }

            set
            {
                DiemTb = value;
            }
        }
    }
}
