using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Repository
{
    public class Use_Repository
    {
        MyContext my;
        public Use_Repository()
        {
            my = new MyContext();
        }

        public List<Taikhoan> GetTK()
        {
            return my.Taikhoans.ToList();
        }
        //Xác định tài khoản có tồn tại hay không

        public bool Add_TK(Taikhoan tk)
        {
            if(tk  == null)
            {
                return false;
            }
            my.Taikhoans.Add(tk);
            my.SaveChanges();
            return true;
        }
        public bool Update_TK(Taikhoan tk)
        {
            if (tk == null)
            {
                return false;
            }
            my.Taikhoans.Update(tk);
            my.SaveChanges();
            return true;
        }

        public bool IsUseFound(string usename, string password)
        {
            if (my.Taikhoans.Any(x => x.Tentk.Equals(usename) && x.Matkhau.Equals(password)))
            {
                return true;
            }
            return false;
        }

        public string UseNv_ID(string username)
        {
            var account = my.Taikhoans.FirstOrDefault(x => x.Matk.Equals(username));
            return account != null ? account.Matk : null;
        }
    }
}
