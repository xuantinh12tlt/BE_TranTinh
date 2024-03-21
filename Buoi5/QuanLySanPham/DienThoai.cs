using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.QuanLySanPham
{
    public class DienThoai : SanPham
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string DungLuongBoNho { get; set; }
        public DienThoai(string MaLoaiSanPham, string TenLoaiSP, string msp, string tensp, int soluong, decimal dg, string brand, string model, string dungluongbonho) : base(MaLoaiSanPham, TenLoaiSP, msp, tensp, soluong, dg)
        {
            this.Brand = brand;
            this.Model = model;
            this.DungLuongBoNho = dungluongbonho;
        }     
        public decimal ThanhTien()
        {
            return SoLuong * DonGia;
        }
    }
}
