using DAl_Du_An_4.DomainClass;
using DAl_Du_An_4.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Service
{
    public class Hoadon_Service
    {
        Hoadon_Repository hd_re;

        public Hoadon_Service()
        {
            hd_re = new Hoadon_Repository();
        }

        public List<Hoadon> GetHoadons()
        {
            //if(seacher == null || seacher == string.Empty)
            //{
            //    //return hd_re.GetHD();
            //}
            //else
            //{
            //    return hd_re.GetHD().Where(x => x.Mahd.ToUpper().Contains(seacher) ||
            //    x.Manv.ToUpper().Contains(seacher.ToUpper())).ToList();
            //}
            return hd_re.GetHD();
        }

        public List<Hoadonchitiet> GetHoadonchitiets()
        {
            return hd_re.Gethdct();
        }

        public string Them_HD(Hoadon hd)
        {
            if (hd_re.Add_HD(hd))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string Xoa_HD(Hoadon hd)
        {
            if (hd_re.Remove_HD(hd))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string CapNhap_HD(Hoadon hd)
        {
            if (hd_re.Update_HD(hd))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhật thất bại";
            }
        }

        public void Them_HDCT(Hoadonchitiet hdct)
        {
            if (GetHoadonchitiets().Any(x => x.Masp == hdct.Masp && x.Mahdct == hdct.Mahdct))
            {
                var updatehoadon = hd_re.Gethdct().FirstOrDefault(x => x.Mahdct == hdct.Mahdct && x.Masp == hdct.Masp);

                // Kiểm tra sự tồn tại của đối tượng trước khi cập nhật
                if (updatehoadon != null)
                {
                    updatehoadon.Soluong++;
                    hd_re.Update_HDCT(updatehoadon);
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy đối tượng cần cập nhật
                    throw new Exception("Không tìm thấy hóa đơn chi tiết cần cập nhật.");
                }
            }
            else
            {
                hdct.Soluong = 1;
                hd_re.Add_HDCT(hdct);
            }
        }
        public void Remove_HDCT(Hoadonchitiet hdct)
        {
            if ( hdct != null)
            {
                hd_re.RemoveHDCT(hdct);
            }
        }
    }
}
