using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Ticaret_Süt_Ürünleri.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Ad")]
        public string Isim { get; set; }
        [Required]
        [DisplayName("Soyad")]
        public string Soyisim { get; set; }
        [Required]
        [DisplayName("Kullanıcı Ad")]
        public string KullaniciAd { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="Lütfen kullanılabilir bir email giriniz..")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Sifre", ErrorMessage ="Şifreler aynı değil..")]
        public string TekrarSifre { get; set; }
    }
}