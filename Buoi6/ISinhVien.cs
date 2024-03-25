using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    public interface ISinhVien
    {
        /*
        1. Thêm sinh viên.
        2. Cập nhật thông tin sinh viên bởi ID.
        3. Xóa sinh viên bởi ID.
        4. Tìm kiếm sinh viên theo tên.
        5. Sắp xếp sinh viên theo điểm trung bình (GPA).
        6. Sắp xếp sinh viên theo tên.
        6. Sắp xếp sinh viên theo ID.
        8. Hiển thị danh sách sinh vien.
         */

        public string AddSinhVien(List<SinhVien> Listsv,SinhVien sv);
        public void UpdateSinhvien(List<SinhVien> listSV, string ID, string TenSV, string GioiTinh, int Tuoi, float dToan, float dLy, float dHoa);
        public void DeleteSinhVien(List<SinhVien> listSV, string ID);
        public List<SinhVien> SearchSinhVien(List<SinhVien> DanhSachSV, string TenSV);
        public void SortSinhVienByGPA(List<SinhVien> listSV);
        public void SortSinhVienByTen(List<SinhVien> listSV);
        public void SortSinhVienByID(List<SinhVien> listSV);
        public void DisplaySinhVien(List<SinhVien> listSV);



    }
}
