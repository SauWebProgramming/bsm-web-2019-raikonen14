using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Models
{
    public class ProductModel
    {

        public int Id { get; set; }

        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public int Stok { get; set; }
   

        public int KatagoriId { get; set; }
    }
}