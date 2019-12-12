using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Entity
{
    public class Katagori
    {
        public int Id { get; set; }

        public string Isim { get; set; }
        public string Aciklama { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}