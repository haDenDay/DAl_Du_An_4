using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Repository
{
    public class KH_KM_Repository
    {
        MyContext my;

        public KH_KM_Repository()
        {
            my = new MyContext();
        }

        public List<Khachhang> GetKH()
        {
            return my.Khachhangs.ToList();
        }

        public List<Khuyenmai> GetKM()
        {
            return my.Khuyenmais.ToList();
        }
    }
}
