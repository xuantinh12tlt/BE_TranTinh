using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Hinh
{
    public class HinhTron : Hinh
    {
        public int BanKinh { get; set; }
        public override double ChuVi()
        {
            return BanKinh * 2 * Math.PI;
        }

        public override double DienTich()
        {
            return BanKinh * BanKinh * Math.PI;
        }
    }
}
