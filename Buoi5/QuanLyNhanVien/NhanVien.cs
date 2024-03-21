using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.QuanLyNhanVien
{
    public class NhanVien:LoaiNhanVien
    {
        public string? MaNV { get; set; }
        public string? TenNV { get; set; }
        public int SoNgayCongThucTe { get; set; }
        public int SoNgayCongChuan { get; set; }
        public double LuongCoBan { get; set; }
        public double PhuCap { get; set; }
        public double LuongThucNhan { get; set; }


        public NhanVien(string tenloainhanvien, double hsl) : base(tenloainhanvien, hsl)
        {
        }


        public override double TinhLuong()
        {
            double TienLuongThucNhan = (LuongCoBan*HeSoLuong + PhuCap) / SoNgayCongChuan * SoNgayCongThucTe;
            return TienLuongThucNhan;
        }

    }
}
