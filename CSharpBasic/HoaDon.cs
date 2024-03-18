using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    struct HoaDon
    {
        // Mã hóa đơn , ngày phát hành , số tiền, người mua , ngày mua
        private string MHD;
        private DateTime NgayPhatHanh;
        private decimal SoTien;
        private string NguoiMua;
        private DateTime NgayMua;

        public string _MaHoaDon
        {
            get { return MHD; }
            set { MHD = value; }
        }

        public DateTime _NgayPhatHanh
        {
            get { return NgayPhatHanh; }
            set { NgayPhatHanh = value; }
        }

        public decimal _SoTien
        {
            get { return SoTien; }
            set { SoTien = value; }
        }

        public string _NguoiMua
        {
            get { return NguoiMua;  }
            set { NguoiMua = value; }
        }

        public DateTime _NgayMua
        {
            get { return NgayMua; }
            set { NgayMua = value;  }
        }


        //Nhập hóa đơn , xóa hóa đơn , sửa hóa đơn , danh sách hóa đơn 
        public HoaDon NhapHoaDon()
        {
            HoaDon hd = new HoaDon();

            Console.WriteLine("Nhap ma hoa don \t" );
            MHD = Console.ReadLine() ?? "";
            hd.MHD = MHD;

            Console.WriteLine("Nhap ngay phat hanh \t");
            NgayPhatHanh =  Convert.ToDateTime(Console.ReadLine());
            hd.NgayPhatHanh = NgayPhatHanh;

            Console.WriteLine("Nhap nguoi mua \t");
            NguoiMua = Console.ReadLine() ?? "";
            hd.NgayPhatHanh = NgayPhatHanh;

            Console.WriteLine("Nhap so tien \t");
            SoTien = Convert.ToDecimal(Console.ReadLine());
            hd.SoTien = SoTien;

            NgayMua = DateTime.Now;
            hd.NgayMua = NgayMua;

            return hd;
        }


        public List<HoaDon> XoaHoaDong(List<HoaDon> lsHoaDon ,string MaHoaDon)
        {
            List<HoaDon> lsHoaDonNew = new List<HoaDon>();
            lsHoaDonNew = lsHoaDon.Where(p => p.MHD != MaHoaDon).ToList();
            return lsHoaDonNew;
        }

        public void SuaHoaHoaDon(string mhd, DateTime ngayphathanh, decimal sotien, string nguoimua, DateTime ngaymua)
        {
            if(_MaHoaDon == mhd)
            {
                _NgayPhatHanh = ngayphathanh;
                _SoTien = sotien;
                _NguoiMua = nguoimua;
                _NgayMua = ngaymua;
            }

        }

        public List<HoaDon> TimKiemHoaDon(List<HoaDon> lsthd, string mhd, DateTime ngayphathanh, string nguoimua, DateTime ngaymua)
        {
            lsthd = lsthd.Where(p => p.MHD.Contains(mhd) || p.NgayPhatHanh <= ngayphathanh || p.NguoiMua.Contains(nguoimua)|| p.NgayMua <= ngaymua).ToList();  
               
            return lsthd;

        }
    }

}
