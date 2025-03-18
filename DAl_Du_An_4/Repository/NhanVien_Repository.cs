using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Repository
{
    public class NhanVien_Repository
    {
        MyContext my;

        public NhanVien_Repository()
        {
            my = new MyContext();
        }

        public List<Taikhoan> GetTK()
        {
            return my.Taikhoans.ToList();
        }
        public List<Nhanvien> GetAllNV()
        {
            return my.Nhanviens.ToList();
        }

        public bool Add_Obj(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            my.Nhanviens.Add(nv);
            my.SaveChanges();
            return true;
        }

        public bool UpDate_Obj(Nhanvien nv)
        {
            if (nv == null)
            {
                return false;
            }
            my.Nhanviens.Update(nv);
            my.SaveChanges();
            return true;
        }
        public string UseNv_MaNV(string MaNV)
        {
            return my.Nhanviens.FirstOrDefault(x => x.Manv.Equals(MaNV)).Manv;
        }
    }
}
