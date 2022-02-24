using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbGiaoVien
    {
        string MaGV;
        string TenGV;
        string GioiTinh;
        string Phone;
        string Email;
        string GiangDayMon;
        string MaLop;

        public tbGiaoVien(string maGV, string tenGV, string gioiTinh, string phone, string email, string giangDayMon, string maLop, string maGV1, string tenGV1, string gioiTinh1, string phone1, string email1, string giangDayMon1, string maLop1)
        {
            MaGV = maGV;
            TenGV = tenGV;
            GioiTinh = gioiTinh;
            Phone = phone;
            Email = email;
            GiangDayMon = giangDayMon;
            MaLop = maLop;
            MaGV1 = maGV1;
            TenGV1 = tenGV1;
            GioiTinh1 = gioiTinh1;
            Phone1 = phone1;
            Email1 = email1;
            GiangDayMon1 = giangDayMon1;
            MaLop1 = maLop1;
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
