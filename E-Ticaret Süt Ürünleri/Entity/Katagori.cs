using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Entity
{
    public class Katagori
    {
        public int Id { get; set; }
        [DisplayName ("Kategori İsmi")]
        public string Isim { get; set; }
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}