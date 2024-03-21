using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.QuanLyNhanVien
{
    public abstract class LoaiNhanVien
    {
        public string TenLoaiNhanVien { get; set; }
        public double HeSoLuong { get; set; }
        public LoaiNhanVien(string Tenloainhanvien, double HSL)
        {
            TenLoaiNhanVien = Tenloainhanvien;
            HeSoLuong = HSL;

        }
        public abstract double TinhLuong();

        
    }
}
