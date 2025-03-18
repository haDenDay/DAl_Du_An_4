using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Service
{
    public class Use_Service
    {
        Use_Repository use_repo;

        public Use_Service()
        {
            use_repo = new Use_Repository();

        }

        public List<Taikhoan> GetTaikhoans(string seacher)
        {
            if (seacher == null || seacher == string.Empty)
            {
                return use_repo.GetTK();
            }
            else
            {
                return use_repo.GetTK().Where(x => x.Matk.ToUpper().Contains(seacher) ||
                x.Phanloaitk.ToUpper().Contains(seacher.ToUpper())).ToList();
            }
        }
        public string Them_TK(Taikhoan tk)
        {
            if (use_repo.Add_TK(tk))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhat_TK(Taikhoan tk)
        {
            if (use_repo.Update_TK(tk))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }

        public string CheckLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Yêu cầu không được để trống";
            }
            else if (use_repo.IsUseFound(username, password))
            {
                return "Đăng nhập thành công";
            }
            else
            {
                return "Sai tài khoản hoặc mật khẩu";
            }
        }

        public string GetMatk(string usename)
        {
            return use_repo.UseNv_ID(usename);
        }
    }
}
