using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Hinh
{
    public class HinhChuNhat : Hinh
    {
        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }

        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override double ChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        public  bool checkIsNumber(string number)
        {
            int a;
            if (int.TryParse(number, out a))
            {
                if (a < 0 || a > int.MaxValue)
                    return false;
                return true;
            }
            return false;

        }
    }
}
