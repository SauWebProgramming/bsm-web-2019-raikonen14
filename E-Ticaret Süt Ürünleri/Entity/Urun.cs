using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Entity
{
    public class Urun
    {
        public int Id { get; set; }

        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public bool Anasayfa { get; set; }
        public bool Aktif { get; set; }

        public int KatagoriId { get; set; }
        public  Katagori Katagori { get; set; }
    }
}