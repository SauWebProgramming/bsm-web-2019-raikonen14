using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Entity
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var katagoriler = new List<Katagori>()
            {
                 new Katagori(){Isim="Süt" , Aciklama="Süt Ürünleri"},
                 new Katagori(){Isim="Yoğurt" , Aciklama="Yoğurt Ürünleri"},
                 new Katagori(){Isim="Peynir" , Aciklama="Peynir Ürünleri"},
                 new Katagori(){Isim="Kaymak" , Aciklama="Kaymak Ürünleri"},
                 new Katagori(){Isim="Krema" , Aciklama="Krema Ürünleri"},
            };

            foreach (var katagori in katagoriler)
            {
                context.Katagoriler.Add(katagori);
            }
            context.SaveChanges();


            var urunler = new List<Urun>()
            {

                new Urun(){Isim="İnek Sütü", Aciklama="Doğal Üretim",Fiyat=30,Stok=10,Aktif=true,KatagoriId=1, Anasayfa=true,Resim="1.jpg"},
                new Urun() { Isim = "Keçi Sütü", Aciklama = "Doğal Üretim", Fiyat = 25, Stok = 20, Aktif = true, KatagoriId = 1, Anasayfa=true,Resim="2.jpg" },
                new Urun(){Isim="Badem Sütü", Aciklama="Doğal Üretim",Fiyat=100,Stok=10,Aktif=true,KatagoriId=1, Anasayfa=true,Resim="3.jpg"},
                new Urun() { Isim = "Soya Sütü", Aciklama = "Doğal Üretim", Fiyat = 90, Stok = 20, Aktif = true, KatagoriId = 1, Anasayfa=true,Resim="4.jpg" },
                new Urun() { Isim = "Yulaf Sütü", Aciklama = "Doğal Üretim", Fiyat = 60, Stok = 20, Aktif = true, KatagoriId = 1, Anasayfa=true,Resim="5.jpg" },


                new Urun(){Isim="Tam Yağlı Yoğurt", Aciklama="İnek Sütüyle Doğal Yapım(kg)",Fiyat=20,Stok=20,Aktif=true,KatagoriId=2, Anasayfa=true,Resim="1.jpg"},
                new Urun(){Isim="Yarım Yağlı Yoğurt", Aciklama="İnek Sütüyle Doğal Yapım(kg)",Fiyat=20,Stok=20,Aktif=true,KatagoriId=2, Anasayfa=true,Resim="2.jpg"},
                new Urun(){Isim="Süzme Yoğurt", Aciklama="İnek Sütüyle Doğal Yapım(kg)",Fiyat=20,Stok=20,Aktif=true,KatagoriId=2, Anasayfa=true,Resim="3.jpg"},
                new Urun(){Isim="Laktozsuz Yoğurt", Aciklama="İnek Sütüyle Doğal Yapım(kg)",Fiyat=20,Stok=20,Aktif=true,KatagoriId=2, Anasayfa=true,Resim="4.jpg"},
                new Urun(){Isim="Light Yoğurt", Aciklama="İnek Sütüyle Doğal Yapım(kg)",Fiyat=20,Stok=20,Aktif=true,KatagoriId=2, Anasayfa=true,Resim="5.jpg"},


                new Urun(){Isim="Kaşar Peynir", Aciklama="Doğal Yapım",Fiyat=30,Stok=20,Aktif=true,KatagoriId=3, Anasayfa=true,Resim="1.jpg"},
                new Urun(){Isim="Keçi Peynir", Aciklama="Keçi Sütüyle Doğal Yapım",Fiyat=25,Stok=20,Aktif=true,KatagoriId=3, Anasayfa=true,Resim="2.jpg"},
                new Urun(){Isim="Cheddar Peynir", Aciklama="Doğal Yapım",Fiyat=30,Stok=20,Aktif=true,KatagoriId=3, Anasayfa=true,Resim="3.jpg"},
                new Urun(){Isim="Ezine Peynir", Aciklama="Doğal Yapım",Fiyat=25,Stok=20,Aktif=true,KatagoriId=3, Anasayfa=true,Resim="4.jpg"},
                new Urun(){Isim="İzmir Tulumu", Aciklama="Doğal Yapım",Fiyat=30,Stok=20,Aktif=true,KatagoriId=3, Anasayfa=true,Resim="5.jpg"},


                new Urun(){Isim="Süt Kaymak", Aciklama=" İnek Sütüyle Doğal Üretim",Fiyat=50,Stok=20,Aktif=true,KatagoriId=4, Anasayfa=true,Resim="1.jpg"},
                new Urun(){Isim="Yoğurt Kaymak", Aciklama="İnek Sütüyle Doğal Üretim",Fiyat=40,Stok=20,Aktif=true,KatagoriId=4, Anasayfa=true,Resim="2.jpg"},
                new Urun(){Isim="Manda Sütü Kaymak", Aciklama=" Manda Sütüyle Doğal Üretim",Fiyat=70,Stok=20,Aktif=true,KatagoriId=4, Anasayfa=true,Resim="3.jpg"},
                new Urun(){Isim="Bolu Kaymak", Aciklama="İnek Sütüyle Doğal Üretim",Fiyat=40,Stok=20,Aktif=true,KatagoriId=4, Anasayfa=true,Resim="4.jpg"},
                new Urun(){Isim="Göynük Kaymak", Aciklama="İnek Sütüyle Doğal Üretim",Fiyat=40,Stok=20,Aktif=true,KatagoriId=4, Anasayfa=true,Resim="5.jpg"},


            };

            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}