using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbsearch
    {
        private string MaHS;
        private string HoTen;
        private string NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string MaLop;

        public tbsearch(string maHS, string hoTen, string ngaySinh, string gioiTinh, string diaChi, string maLop)
        {
            MaHS = maHS;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MaLop = maLop;
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

        public string NgaySinh1
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
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

        public string DiaChi1
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
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
