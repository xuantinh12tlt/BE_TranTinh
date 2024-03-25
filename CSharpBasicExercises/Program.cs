// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 void PhepTinh2So()
{
    Console.WriteLine("Chuong trinh tinh ket qua 2 so");
    Console.WriteLine("Nhap so thu nhat");
    string? SoThuNhat;
    SoThuNhat = Console.ReadLine();
    int? iSoThuNhat = 0;
    decimal? iSoThuHai = 0;
    while (!SharedLibrary.SharedLibrary.CheckIsInt(SoThuNhat==null?"":SoThuNhat))
    {
        Console.WriteLine("Du lieu khong hop le, phai la kieu so");
        Console.WriteLine("Nhap so thu nhat");
        SoThuNhat = Console.ReadLine();
    }
    iSoThuNhat = int.Parse(SoThuNhat==null?"0": SoThuNhat);

    Console.WriteLine("Nhap so thu hai");
    string? SoThuHai;
    SoThuHai = Console.ReadLine();
    while (!SharedLibrary.SharedLibrary.CheckIsInt(SoThuHai == null ? "" : SoThuHai))
    {
        Console.WriteLine("Du lieu khong hop le, phai la kieu so");
        Console.WriteLine("Nhap so thu hai");
        SoThuHai = Console.ReadLine();
    }
    iSoThuHai = int.Parse(SoThuHai == null ? "0" : SoThuHai);
    if (!string.IsNullOrEmpty(SoThuHai) && !string.IsNullOrEmpty(SoThuNhat))
    {
        Console.WriteLine("Ket qua phep cong \t{0}", iSoThuNhat + iSoThuHai);
        Console.WriteLine("Ket qua phep tru \t{0}", iSoThuNhat - iSoThuHai);
        Console.WriteLine("Ket qua phep nhan \t{0}", iSoThuNhat* iSoThuHai);
        Console.WriteLine("Ket qua phep chia \t{0}", iSoThuNhat / iSoThuHai);

    }   

}


void GiaiPhuongTrinhBacNhat()
{
    Console.WriteLine("\n***Giai Phuong Trinh Bac Nhat ***");
    string? a;
    string? b;
    Console.Write("a=");
    a = Console.ReadLine();
    while(!SharedLibrary.SharedLibrary.CheckIsInt(a))
    {
        Console.Write("Vui long nhap lai a");
        a = Console.ReadLine();
    }
    Console.WriteLine("b=");
    b = Console.ReadLine();
    while (!SharedLibrary.SharedLibrary.CheckIsInt(a))
    {
        Console.Write("Vui long nhap lai b=");
        b = Console.ReadLine();
    }

    if(int.Parse(a)==0 && int.Parse(b)!=0)
    {
        Console.WriteLine("Phuong trinh vo nghiem");
    }    
    else
    {
        Console.WriteLine("Nghiem cua PT bac nhat là {0} \t", (-int.Parse(b = string.IsNullOrEmpty(b) ? "0" : b)) / int.Parse(a));
    }    
    
}

GiaiPhuongTrinhBacNhat();
PhepTinh2So();