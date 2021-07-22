using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonNhom1
{
    class SinhVienBLL
    {
        SinhVienDAL dalSV;
        public SinhVienBLL()
        {
            dalSV = new SinhVienDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
        public bool Insert(tblSinhVien sv)
        {
            return dalSV.Insert(sv);

        }
        public bool update(tblSinhVien sv)
        {
            return dalSV.update(sv);
        }
        public bool delete(tblSinhVien sv)
        {
            return dalSV.delete(sv);
        }
        public DataTable timkiem(string sv)
        {
            return dalSV.timkiem(sv);
        }
        
    }
}
