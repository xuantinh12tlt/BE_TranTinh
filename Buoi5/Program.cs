// See https://aka.ms/new-console-template for more information
using Buoi5.Hinh;
using Buoi5.QuanLyNhanVien;
using Buoi5.QuanLySanPham;

Console.WriteLine("Chuong trinh quan ly hinh");
Console.WriteLine("HCN");
HinhChuNhat hcn = new HinhChuNhat();
hcn.ChieuDai = 5;
hcn.ChieuRong = 10;
Console.WriteLine("Dien tich hinh CN: \t " + hcn.DienTich());
Console.WriteLine("Chu vi hinh CN \t" + hcn.ChuVi());

Console.WriteLine("HINH TRON ");

HinhTron HT = new HinhTron();
HT.BanKinh = 20;
Console.WriteLine("Dien tich hinh tron: \t " + HT.DienTich());
Console.WriteLine("Chu vi hinh tron \t" + HT.ChuVi());


Console.WriteLine("\n **********************");

Console.WriteLine("\nChuong trinh quan ly Nhan Vien");

NhanVien nvPartTime = new NhanVien("BanThoiGian", 1.5);
nvPartTime.MaNV = "001";
nvPartTime.TenNV = "Le Anh Tuan";
nvPartTime.SoNgayCongChuan = 26;
nvPartTime.SoNgayCongThucTe = 27;
nvPartTime.LuongCoBan = 2000000;
nvPartTime.PhuCap = 500000;
nvPartTime.LuongThucNhan = nvPartTime.TinhLuong();

Console.WriteLine("Ma NV \t" + nvPartTime.MaNV);
Console.WriteLine("Ten NV \t" + nvPartTime.TenNV);
Console.WriteLine("Loai NV \t" + nvPartTime.TenLoaiNhanVien);
Console.WriteLine("Ngay cong chuan \t" + nvPartTime.SoNgayCongChuan);
Console.WriteLine("Ngay cong thuc te \t" + nvPartTime.SoNgayCongThucTe);
Console.WriteLine("HSL \t" + nvPartTime.HeSoLuong);
Console.WriteLine("LCB \t" + nvPartTime.LuongCoBan);
Console.WriteLine("PC \t" + nvPartTime.PhuCap);
Console.WriteLine("Luong Thuc nhan \t" + nvPartTime.LuongThucNhan);


Console.WriteLine("\n **********************");

Console.WriteLine("\nChuong trinh quan ly SanPham");

DienThoai dt = new DienThoai("009","Dien Thoai Cam Tay","4949494", "OPPO A78", 5, 2500000, "Oppo", "OPPO A78", "128");
decimal ThanhTien = dt.ThanhTien();
Console.WriteLine("Ma Loai San Pham \t" + dt.MaLoaiSanPham);
Console.WriteLine("Ten Loai  San Pham \t" + dt.TenLoaiSanPham);
Console.WriteLine("Ma San Pham \t" + dt.MaSP);
Console.WriteLine("Ten  San Pham \t" + dt.TenSP);
Console.WriteLine("So luong \t" + dt.SoLuong);
Console.WriteLine("Gia ban \t" + dt.DonGia);
Console.WriteLine("Brand \t" + dt.Brand);
Console.WriteLine("Model \t" + dt.Model);
Console.WriteLine("Dung luong Bo Nho \t" + dt.DungLuongBoNho);
Console.WriteLine("Thanh Tien \t" + ThanhTien);


Console.ReadKey();