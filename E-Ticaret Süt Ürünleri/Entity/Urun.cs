using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Entity
{
    public class Urun
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Isim { get; set; }
        [DisplayName("Ürün Açıklama")]
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public int Stok { get; set; }
        public bool Anasayfa { get; set; }
        public bool Aktif { get; set; }

        public int KatagoriId { get; set; }
        public  Katagori Katagori { get; set; }
    }
}