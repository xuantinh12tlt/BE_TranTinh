using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.QuanLySanPham
{
    public abstract class SanPham : LoaiSanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public SanPham(string MaLoaiSanPham, string TenLoaiSP, string msp, string tensp, int soluong, decimal dg):base(MaLoaiSanPham, MaLoaiSanPham)
        {
            //this.MaLoaiSanPham = MaLoaiSanPham;
            //this.TenLoaiSanPham = TenLoaiSP;
            this.MaSP = msp;
            this.TenSP = tensp;
            this.SoLuong = soluong;
            this.DonGia = dg;
        }

        public decimal GiaBan()
        {
            return SoLuong * DonGia;
        }
       
    }
}
