using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    public class SinhVien : ISinhVien
    {
        /*
        * Mỗi đối tượng sinh viên có các thuộc tính sau: id, tên, giới tính, tuổi, điểm toán, điểm lý, điểm hóa, điểm trung bình và học lực.

        Id : là mã sinh viên tự động bằng GUI.
        Điểm trung bình :  là giá trị trung bình của 3 môn toán, lý và hóa.

        Học lực được tính như sau:
        Giỏi: nếu điểm trung bình lớn hơn hoặc bằng 8.
        Khá: nếu điểm trung bình nhỏ hơn 8 và lớn hơn hoặc bằng 6.5.
        Trung Bình: nếu điểm trung bình nhỏ hơn 6.5 và lớn hơn hoặc bằng 5.
        Yếu: nếu điểm trung bình nhỏ hơn 5.*/

        public string ID { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public float DToan { get; set; }
        public float DLy { get; set; }
        public float DHoa { get; set; } 



        public float _DTB
        {
            get {
                float DTB = (DToan + DLy + DHoa) / 3;
                return DTB;
            }
            set => _DTB = value;
        }

        public string _HocLuc
        {
            get
            {
                string HocLuc = "Chua xep loai";
                if (_DTB >= 8)
                    HocLuc = "Giỏi";
                if (_DTB < 8 && _DTB >= 6.5)
                    HocLuc = "Khá";
                if (_DTB < 6.5 && _DTB >= 5)
                    HocLuc = "Trung Binh";
                if (_DTB < 5 && _DTB >= 0)
                    HocLuc = "Yeu";
                return HocLuc;

            }
            set => _HocLuc = value;
        }

        public string AddSinhVien(List<SinhVien> ListSV, SinhVien sv)
        {
            string MaHS = "";
            if(sv!=null)
            {
                MaHS = Guid.NewGuid().ToString();
                sv.ID = MaHS;
                ListSV.Add(sv);
            }
            return MaHS;
        }
        public void DeleteSinhVien(List<SinhVien> listSV ,string ID)
        {
            var SVCanXoa = listSV.Where(p => p.ID == ID).FirstOrDefault();
            if(SVCanXoa!=null)
            {
                listSV.Remove(SVCanXoa);
            }
        }

        public void DisplaySinhVien(List<SinhVien> listSV)
        {
            if(listSV != null && listSV.Count >0)
            {
                Console.WriteLine("Danh Sach Sinh Vien");
                Console.WriteLine("Ten\t GioiTinh\t Tuoi\t DiemToan\t DiemLy\t DiemHoa\t DTB\t HocLuc\t");
                foreach (var SVItem in listSV)
                {
                    Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t {7}\t", SVItem.Ten, SVItem.GioiTinh, SVItem.Tuoi, SVItem.DToan, SVItem.DLy, SVItem.DHoa, SVItem._DTB, SVItem._HocLuc);
                }    

            }    
            //throw new NotImplementedException();
        }

        public List<SinhVien> SearchSinhVien(List<SinhVien> DanhSachSV, string TenSV)
        {
            List<SinhVien> lstDanhSachSVCanTim = new List<SinhVien>();
            lstDanhSachSVCanTim = DanhSachSV.Where(p => p.Ten.Contains(TenSV)).ToList();
            return lstDanhSachSVCanTim;
        }

        public void SortSinhVienByGPA(List<SinhVien> listSV)
        {
            listSV = listSV.OrderBy(p=>p._DTB).ToList();
        }

        public void SortSinhVienByID(List<SinhVien> listSV)
        {
            listSV = listSV.OrderBy(p => p.ID).ToList();
        }

        public void SortSinhVienByTen(List<SinhVien> listSV)
        {
            listSV = listSV.OrderBy(p => p.Ten).ToList();
        }

        public void UpdateSinhvien(List<SinhVien> listSV, string ID, string TenSV, string GioiTinh, int Tuoi, float dToan, float dLy, float dHoa)
        {
            var svNeedUpdate = listSV.FirstOrDefault(p=>p.ID == ID);
            if(svNeedUpdate != null)
            {
                svNeedUpdate.Ten = TenSV;
                svNeedUpdate.GioiTinh = TenSV;
                svNeedUpdate.Tuoi = Tuoi;
                svNeedUpdate.DToan = dToan;
                svNeedUpdate.DLy = dLy;
                svNeedUpdate.DHoa = dHoa;

            }
        }

        public SinhVien NhapThongTinSV()
        {
            SinhVien sv = new SinhVien();
            Console.Write("Ten:\t");
            sv.Ten = Console.ReadLine();
            Console.Write("Gioi tinh:\t");
            sv.GioiTinh = Console.ReadLine();
            Console.Write("Tuoi:\t");
            sv.Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem Toan:\t");
            sv.DToan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem Ly:\t");
            sv.DLy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem Hoa:\t");
            sv.DHoa = Convert.ToInt32(Console.ReadLine());
            return sv;
        }
    }
}
