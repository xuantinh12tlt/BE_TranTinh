using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.QuanLySanPham
{
    public abstract class LoaiSanPham
    {
        public string MaLoaiSanPham { get; set; }
        public string TenLoaiSanPham { get; set; }

        public LoaiSanPham(string mlsp, string tenloaisp)
        {
            MaLoaiSanPham = mlsp;
            TenLoaiSanPham = tenloaisp;
        }

    }
}
