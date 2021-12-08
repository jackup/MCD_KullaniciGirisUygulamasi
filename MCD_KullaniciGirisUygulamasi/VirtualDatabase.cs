using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KullaniciGirisUygulamasi
{
    public class VirtualDatabase
    {
        public static List<Kullanici> kTablo = new List<Kullanici>();
        static VirtualDatabase()
        {
            kTablo.Add(new Kullanici() { 
            id = 1,
            isim = "Brad",
            soyisim = "Pitt",
            kullaniciAdi = "achilles",
            sifre = "1234",
            aciklama = "Brad Pitt Kullanıcı Bilgisi"
            });

            kTablo.Add(new Kullanici()
            {
                id = 2,
                isim = "Edward",
                soyisim = "Norton",
                kullaniciAdi = "hulk",
                sifre = "2345",
                aciklama = "Edward Norton Kullanıcı Bilgisi"
            });
        }
    }
}
