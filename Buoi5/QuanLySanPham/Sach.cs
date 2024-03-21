using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.QuanLySanPham
{
    class Sach : SanPham
    {
        public Sach(string MaLoaiSanPham, string TenLoaiSP, string msp, string tensp, int soluong, decimal dg) : base(MaLoaiSanPham, TenLoaiSP, msp, tensp, soluong, dg)
        {
        }
    }
}
