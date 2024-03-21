// See https://aka.ms/new-console-template for more information
using CSharpBasic;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

Console.WriteLine("Hello, World!");
//Viết một chương trình hiển thị một menu có các lựa chọn
//1. Nhập hóa đơn
//2. xóa hóa đơn
//3.sửa hóa đơn 
//4.danh sách hóa đơn 
//5.tìm kiếm hóa đơn theo mã hóa đơn
List<HoaDon> lsHoaDon = new List<HoaDon>();

Console.WriteLine("Menu");
StringBuilder smneu = new StringBuilder();
smneu.AppendLine("1. Nhap hoa don");
smneu.AppendLine("2. Xoa Hoa Don");
smneu.AppendLine("3. Sua Hoa Don");
smneu.AppendLine("4. Danh Sach Hoa Don");
smneu.AppendLine("5.Tim Kiem Hoa Don");
Console.WriteLine(smneu);



int iMenu = 0; 
HoaDon hd;
while(iMenu<=5)
{
    Console.WriteLine("Nhap phim tuong ung de chon chuc nang");
    iMenu = Convert.ToInt32(Console.ReadLine());

    switch (iMenu)
    {
        case 1:
            hd = new HoaDon();
            hd.NhapHoaDon();
            lsHoaDon.Add(hd);

            break;
        case 2:
            Console.WriteLine("Nhap ma hoa don can xoa");
            string mhd = Console.ReadLine() ?? "";
            hd = new HoaDon();
            lsHoaDon = hd.XoaHoaDong(lsHoaDon, mhd);            
            break;

        case 3:
            Console.WriteLine("Sua hoa dong");
            Console.WriteLine("Nhap ma hoa don \t");
            string MHDEdit = Console.ReadLine() ?? "";

            Console.WriteLine("Nhap ngay phat hanh \t");
            DateTime NgayPhatHanhEdit = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Nhap so tien \t");
            decimal SoTienEdit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Nhap nguoi mua \t");
            string NguoiMuaEdit = Console.ReadLine() ?? "";

            Console.WriteLine("Nhap ngay mua \t");
            DateTime NgayMuaEdit = Convert.ToDateTime(Console.ReadLine());
            if (lsHoaDon.Count != 0)
            {
                foreach (var item in lsHoaDon)
                {
                    hd = new HoaDon();
                    hd = item;
                    hd.SuaHoaHoaDon(MHDEdit, NgayPhatHanhEdit, SoTienEdit, NguoiMuaEdit, NgayMuaEdit);
                }
            }
            else
            {
                Console.WriteLine("Khong co hoa don nao can xoa \t");

            }

            break;

        case 4:
            Console.WriteLine("Danh Sach Hoa Don");
            int i = 1;
            foreach (var item1 in lsHoaDon)
            {
                Console.WriteLine("Hoa don thu " + i);
                Console.WriteLine("Ma HD " + item1._MaHoaDon);
                Console.WriteLine("Ngay Phat Hanh " + item1._NgayPhatHanh);
                Console.WriteLine("Ngay Mua " + item1._NgayMua);
                Console.WriteLine("So Tien " + item1._SoTien);
                Console.WriteLine("Nguoi Mua " + item1._NguoiMua);

                Console.WriteLine("*******************");
                i++;

            }
            break;

    case 5:
            Console.WriteLine("Tim Kiem Hoa Don");
            Console.WriteLine("Nhap dieu kien can tim kiem");

            Console.WriteLine("Sua hoa dong");
            Console.Write("Nhap ma hoa don \t");
            string MHDSearch = Console.ReadLine() ?? "";

            Console.WriteLine("Nhap ngay phat hanh \t");
            DateTime NgayPhatHanhSearch =  Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Nhap nguoi mua \t");
            string NguoiMuaSearch = Console.ReadLine() ?? "";

            Console.WriteLine("Nhap ngay mua \t");
            DateTime NgayMuaSearch =  Convert.ToDateTime(Console.ReadLine());

            hd = new HoaDon();
            List<HoaDon> lsts = new List<HoaDon>();
            lsts = hd.TimKiemHoaDon(lsHoaDon, MHDSearch, NgayPhatHanhSearch, NguoiMuaSearch, NgayMuaSearch);

            Console.WriteLine("********** TIM  KIEM HOA DON ******");
            Console.WriteLine("\nHoa Don Can Tim");
            int j = 1;
            foreach (var item1 in lsHoaDon)
            {
                Console.WriteLine("Hoa don thu " + j);
                Console.WriteLine("Ma HD " + item1._MaHoaDon);
                Console.WriteLine("Ngay Phat Hanh " + item1._NgayPhatHanh);
                Console.WriteLine("Ngay Mua " + item1._NgayMua);
                Console.WriteLine("So Tien " + item1._SoTien);
                Console.WriteLine("Nguoi Mua " + item1._NguoiMua);

                Console.WriteLine("*******************");
                j++;

            }
            break;

    }
}    

Console.ReadKey();

/*
 * 
 * Ham la một nhóm các lệnh thực hiện một việc gì đó và có thể tái sử dụng, không nhất thiết là của một đối tượng
 * 
 * Method là hành động gì đó của đối tượng
 * 
 * Ban chat struct là kiểu dữ liệu tham trị, nó
   Class				tham chiếu

class là dai dien cho doi tuong cung dac diem, hanh vi, phuong thuc hanh dong
thuoc tinh: cac dac diem cua doi tuong dc the hien ra ben ngoai

virtual: có hoặc k cần override - abstract: bb
 */