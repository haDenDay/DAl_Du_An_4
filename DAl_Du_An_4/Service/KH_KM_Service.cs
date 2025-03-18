using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Service
{
    public class KH_KM_Service
    {
        KH_KM_Repository kk_re;

        public KH_KM_Service()
        {
            kk_re = new KH_KM_Repository();
        }

        public List<Khachhang> GetKhachhangs()
        {
            return kk_re.GetKH();
        }

        public List<Khuyenmai> GetKhuyenmais()
        {
            return kk_re.GetKM();
        }

    }
}
