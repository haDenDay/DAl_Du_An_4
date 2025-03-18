using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Service
{
    public class CTSP_Service
    {
        CTSP_Repositori ct_re;

        public CTSP_Service()
        {
            ct_re = new CTSP_Repositori();
        }

        public List<Chitietsanpham> GetChitietsanphams()
        {
            //if (seacher == null || seacher == string.Empty)
            //{
            //    return ct_re.GetCTSP();
            //}
            //else
            //{
            //    return ct_re.GetCTSP().Where(x => x.Mactsp.ToUpper().Contains(seacher) ||
            //    x.Masp.ToUpper().Contains(seacher.ToUpper())).ToList();
            //}
            return ct_re.GetCTSP();
        }

        public string ThewmCTSP(Chitietsanpham ctsp)
        {
            if(ct_re.Add_CTSP(ctsp))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public List<Sanpham> GetSanphams()
        {
            return ct_re.GettSP();
        }


        public List<Theloai> GetTheloais()
        {
            return ct_re.GetTL();
        }

        public string ThemTL(Theloai tl)
        {
            if (ct_re.Add_TL(tl))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhatTL(Theloai tl)
        {
            if (ct_re.Update_TL(tl))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }

        public List<Xuatxu> GetXuatxus()
        {
            return ct_re.GetXX();
        }

        public string ThemXX(Xuatxu xx)
        {
            if (ct_re.Add_XX(xx))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhatXX(Xuatxu xx)
        {
            if (ct_re.Update_XX(xx))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }

        public List<Mausac> GetMausacs()
        {
            return ct_re.GetMau();
        }

        public string ThemMS(Mausac ms)
        {
            if (ct_re.Add_Mau(ms))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhatMS(Mausac ms)
        {
            if (ct_re.Update_Mau(ms))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }


        public List<Sizeaonam> GetSizes()
        {
            return ct_re.GetAllS();
        }

        public string ThemS(Sizeaonam s)
        {
            if (ct_re.Add_Size(s))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhatS(Sizeaonam s)
        {
            if (ct_re.Update_Size(s))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }

        public List<Sanpham> GetSanpham()
        {
            return ct_re.GettSP();
        }

        public string ThemSP(Sanpham sp)
        {
            if (ct_re.Add_SP(sp))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string CapNhatSP(Sanpham sp)
        {
            if (ct_re.Update_SP(sp))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }
    }
}
