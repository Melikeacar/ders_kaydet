using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayerr;
using DataAccessLayer;
using System.Runtime.InteropServices.WindowsRuntime;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(Entityogrenci p)
        {
            if(p.Ad !=null && p.Soyad != null && p.Numara != null && p.Sifre != null &&
                p.Fotograf != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<Entityogrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL( int p)
        {
            if ( p>=0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<Entityogrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(Entityogrenci p)
        {
            if (p.Ad != null && p.Ad !="" && p.Soyad != null && p.Numara != null && p.Sifre != null &&
                p.Fotograf != null && p.Id > 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
