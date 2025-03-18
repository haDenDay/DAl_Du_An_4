using DAl_Du_An_4.Context;
using DAl_Du_An_4.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl_Du_An_4.Repository
{
    public class Hoadon_Repository
    {
        MyContext my;

        public Hoadon_Repository()
        {
            my = new MyContext();
        }

        public List<Hoadon> GetHD()
        {
            return my.Hoadons.ToList();
        }

        public List<Hoadonchitiet> Gethdct()
        {
            return my.Hoadonchitiets.ToList();
        }

        public bool Add_HDCT(Hoadonchitiet hdct) 
        {
            if (hdct == null)
            {
                return false;
            }

            string newInvoiceDetailCode;
            var lastInvoiceDetail = my.Hoadonchitiets.OrderByDescending(x => x.Mahdct).FirstOrDefault();

            if (lastInvoiceDetail != null)
            {
                int lastNumber = int.Parse(lastInvoiceDetail.Mahdct.Substring(4));
                int newNumber = lastNumber + 1;
                newInvoiceDetailCode = "HDCT" + newNumber.ToString("D3");
            }
            else
            {
                newInvoiceDetailCode = "HDCT001";
            }

            hdct.Mahdct = newInvoiceDetailCode;
            my.Hoadonchitiets.Add(hdct);
            my.SaveChanges();

            return true;
        }
        public bool Update_HDCT(Hoadonchitiet hdct)
        {
            if (hdct == null)
            {
                return false;
            }
            my.Hoadonchitiets.Add(hdct);
            my.SaveChanges();
            return true;
        }

        public bool Add_HD(Hoadon hd)
        {
            if (hd == null)
            {
                return false;
            }
            string newInvoiceDetailCode;
            var lastInvoiceDetail = my.Hoadons.OrderByDescending(x => x.Mahd).FirstOrDefault();

            if (lastInvoiceDetail != null)
            {
                int lastNumber = int.Parse(lastInvoiceDetail.Mahd.Substring(2));
                int newNumber = lastNumber + 1;
                newInvoiceDetailCode = "HD" + newNumber.ToString("D3");
            }
            else
            {
                newInvoiceDetailCode = "HD001";
            }

            hd.Mahd = newInvoiceDetailCode;
            my.Hoadons.Add(hd);
            my.SaveChanges();
            return true;
        }
        public bool Update_HD(Hoadon hd)
        {
            if (hd == null)
            {
                return false;
            }
            my.Hoadons.Update(hd);
            my.SaveChanges();
            return true;
        }

        public bool Remove_HD(Hoadon hd)
        {
            if (hd == null)
            {
                return false;
            }
            my.Hoadons.Remove(hd);
            my.SaveChanges();
            return true;
        }

        public bool RemoveHDCT(Hoadonchitiet hdct)
        {
            if(hdct == null)
            {
                return false;
            }
            my.Hoadonchitiets.Remove(hdct);
            my.SaveChanges();
            return true;
        }
    }
}
