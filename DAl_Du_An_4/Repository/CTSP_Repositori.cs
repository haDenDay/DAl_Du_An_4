using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Repository
{
    public class CTSP_Repositori
    {
        MyContext my;

        public CTSP_Repositori()
        {
            my = new MyContext();
        }

        public List<Chitietsanpham> GetCTSP()
        {
            return my.Chitietsanphams.ToList();
        }

        public bool Add_CTSP(Chitietsanpham ctsp)
        {
            if (ctsp == null)
            {
                return false;
            }
            my.Chitietsanphams.Add(ctsp);
            my.SaveChanges();
            return true;
        }

        public List<Sanpham> GettSP()
        {
            return my.Sanphams.ToList();
        }

        public bool Add_SP(Sanpham sp)
        {
            if (sp == null)
            {
                return false;
            }
            my.Sanphams.Add(sp);
            my.SaveChanges();
            return true;
        }

        public bool Update_SP(Sanpham sp)
        {
            if (sp == null)
            {
                return false;
            }
            my.Sanphams.Update(sp);
            my.SaveChanges();
            return true;
        }

        public List<Theloai> GetTL()
        {
            return my.Theloais.ToList();
        }
        public bool Add_TL(Theloai tl)
        {
            if (tl == null)
            {
                return false;
            }
            my.Theloais.Add(tl);
            my.SaveChanges();
            return true;
        }

        public bool Update_TL(Theloai tl)
        {
            if (tl == null)
            {
                return false;
            }
            my.Theloais.Update(tl);
            my.SaveChanges();
            return true;
        }

        public List<Sizeaonam> GetAllS()
        {
            return my.Sizeaonams.ToList();
        }

        public bool Add_Size(Sizeaonam s)
        {
            if (s == null)
            {
                return false;
            }
            my.Sizeaonams.Add(s);
            my.SaveChanges();
            return true;
        }

        public bool Update_Size(Sizeaonam s)
        {
            if (s == null)
            {
                return false;
            }
            my.Sizeaonams.Update(s);
            my.SaveChanges();
            return true;
        }
        public List<Mausac> GetMau()
        {
            return my.Mausacs.ToList();
        }

        public bool Add_Mau(Mausac ms)
        {
            if (ms == null)
            {
                return false;
            }
            my.Mausacs.Add(ms);
            my.SaveChanges();
            return true;
        }

        public bool Update_Mau(Mausac ms)
        {
            if (ms == null)
            {
                return false;
            }
            my.Mausacs.Update(ms);
            my.SaveChanges();
            return true;
        }

        public List<Xuatxu> GetXX()
        {
            return my.Xuatxus.ToList();
        }

        public bool Add_XX(Xuatxu xx)
        {
            if (xx == null)
            {
                return false;
            }
            my.Xuatxus.Add(xx);
            my.SaveChanges();
            return true;
        }

        public bool Update_XX(Xuatxu xx)
        {
            if (xx == null)
            {
                return false;
            }
            my.Xuatxus.Update(xx);
            my.SaveChanges();
            return true;
        }
    }
}
