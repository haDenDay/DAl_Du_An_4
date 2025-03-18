using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Service
{
    public class NhanVien_Service
    {
        NhanVien_Repository nv_re;

        public NhanVien_Service()
        {
            nv_re = new NhanVien_Repository();
        }

        public List<Taikhoan> GetTaikhoans()
        {
            return nv_re.GetTK();
        }
        public List<Nhanvien> GetNhanviens(string seacher)
        {
            if (seacher == null || seacher == string.Empty)
            {
                return nv_re.GetAllNV();
            }
            else
            {
                return nv_re.GetAllNV().Where(x => x.Manv.ToUpper().Contains(seacher) ||
                x.Tennv.ToUpper().Contains(seacher.ToUpper())).ToList();
            }
        }

        public string ThemNV(Nhanvien nv)
        {
            if (nv_re.Add_Obj(nv))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhapNV(Nhanvien nv)
        {
            if (nv_re.UpDate_Obj(nv))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }
        public string GetMaNV(string MaNV)
        {
            return nv_re.UseNv_MaNV(MaNV);
        }
    }
}
