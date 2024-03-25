// See https://aka.ms/new-console-template for more information
using Buoi6;
using System.Collections.Generic;
using System.Text;
Console.WriteLine("QUAN LY SINH VIEN!");

StringBuilder smneu = new StringBuilder();
smneu.AppendLine("1. Them Sinh Vien");
smneu.AppendLine("2. Cap Nhap Thong Tin Sinh Vien");
smneu.AppendLine("3. Xoa Thong Tin Sinh Vien");
smneu.AppendLine("4. Tim Kiem Sinh vien Theo Ten");
smneu.AppendLine("5. Sap Xep Sinh Vien Theo Diem TB");
smneu.AppendLine("6. Sap Xep Sinh Vien Theo Ten");
smneu.AppendLine("7. Sap Xep Sinh Vien Theo ID");
smneu.AppendLine("8. Hien Thi Sinh Vien");
Console.WriteLine(smneu);

Console.WriteLine("Nhap phim tuong ung de chon chuc nang");
int iChucNangCanThucHien = 0;
string? sChucNang = Console.ReadLine();
while (!SharedLibrary.SharedLibrary.CheckIsInt(sChucNang == null ? "" : sChucNang))
{
    Console.WriteLine("Không hợp lệ, xin vui lòng chọn lai");
    sChucNang = Console.ReadLine();
}
iChucNangCanThucHien = int.Parse(sChucNang == null ? "0" : sChucNang);

List<SinhVien> lstSinhVien = new List<SinhVien>();
SinhVien sv = new SinhVien();
while (iChucNangCanThucHien <= 8 && iChucNangCanThucHien>0)
{
    switch(iChucNangCanThucHien)
    {
        case 1:
           
            Console.WriteLine("Them Sinh Vien Moi");
            sv = new SinhVien();
            sv.AddSinhVien(lstSinhVien, sv.NhapThongTinSV());
            break;
        case 2:
            Console.WriteLine("Cap Nhap Thong Tinh Sinh Vien");
            Console.WriteLine("Ma Sinh vien:\t");
            string? MaSV = Console.ReadLine();
            Console.WriteLine("Ten:\t");
            string? Ten = Console.ReadLine();
            Console.WriteLine("Gioi tinh:\t");
            string? GioiTinh = Console.ReadLine();
            Console.WriteLine("Tuoi:\t");
            int? Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diem Toan:\t");
            int? DToan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diem Ly:\t");
            int? DLy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diem Hoa:\t");
            int? DHoa = Convert.ToInt32(Console.ReadLine());

            
            var SinhVienCanCapnhat = lstSinhVien.Where(p => p.ID == MaSV).FirstOrDefault();
            if(SinhVienCanCapnhat != null)
            {
                SinhVienCanCapnhat.UpdateSinhvien(lstSinhVien, MaSV, Ten, GioiTinh, Convert.ToInt32(Tuoi.ToString()), Convert.ToInt32(DToan.ToString()), Convert.ToInt32(DLy.ToString()), Convert.ToInt32(DHoa.ToString()));
            }else
            {
                Console.WriteLine("Khong co sinh vien nao duoc cap  nhat");
            }
            break;

        case 3:
            Console.WriteLine("Chon sinh vien can xoa");
            Console.WriteLine("Ma Sinh vien:\t");
            string? MaSVCanXoa = Console.ReadLine();
            sv = new SinhVien();
            sv.DeleteSinhVien(lstSinhVien, MaSVCanXoa==null?"": MaSVCanXoa);
            break;
        case 4:
            Console.WriteLine("Tim kiem theo ten");
            Console.WriteLine("Nhap Ten Can Tim Kiem");
            string TenCanTim = Console.ReadLine();
            sv = new SinhVien();
            List<SinhVien> lstSearch = sv.SearchSinhVien(lstSinhVien, TenCanTim);
            sv.DisplaySinhVien(lstSearch);
            break;
        case 5:
            Console.WriteLine("Sap xep Sinh Vien Theo DTB");
            sv = new SinhVien();
            sv.SortSinhVienByGPA(lstSinhVien);
            break;
        case 6:
            Console.WriteLine("Sap xep Sinh Vien Theo ID");
            sv = new SinhVien();
            sv.SortSinhVienByID(lstSinhVien);
            break;
        case 7:
            Console.WriteLine("Sap xep Sinh Vien Theo Ten");
            sv = new SinhVien();
            sv.SortSinhVienByTen(lstSinhVien);
            break;
        case 8:
            Console.WriteLine("Hien thi Sinh Vien");
            sv = new SinhVien();
            sv.DisplaySinhVien(lstSinhVien);
            break;

    }
    Console.WriteLine("Chon phim chuc nang tuong ung de tiep tuc");
    sChucNang = Console.ReadLine();
    while (!SharedLibrary.SharedLibrary.CheckIsInt(sChucNang == null ? "" : sChucNang))
    {
        Console.WriteLine("Không hợp lệ, xin vui lòng chọn lai");
        sChucNang = Console.ReadLine();
    }
    iChucNangCanThucHien = int.Parse(sChucNang == null ? "0" : sChucNang);
}

Console.ReadKey();

