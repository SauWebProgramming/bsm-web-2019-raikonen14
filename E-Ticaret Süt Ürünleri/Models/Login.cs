using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Ad")]
        public string KullaniciAd { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }
        [Required]
        [DisplayName("Beni Hatırla")]
        public bool BeniHatirla { get; set; }
    }
}