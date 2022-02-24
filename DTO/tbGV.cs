using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class tbGV
    {
        string MaGV;
        string TenGV;
        string GioiTinh;
        string Phone;
        string Email;
        string GiangDayMon;
        string MaLop;

        public tbGV(string maGV, string tenGV, string gioiTinh, string phone, string email, string giangDayMon, string maLop)
        {
            MaGV = maGV;
            TenGV = tenGV;
            GioiTinh = gioiTinh;
            Phone = phone;
            Email = email;
            GiangDayMon = giangDayMon;
            MaLop = maLop;
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

        public string TenGV1
        {
            get
            {
                return TenGV;
            }

            set
            {
                TenGV = value;
            }
        }

        public string GioiTinh1
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }

        public string Phone1
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string GiangDayMon1
        {
            get
            {
                return GiangDayMon;
            }

            set
            {
                GiangDayMon = value;
            }
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
    }
}
