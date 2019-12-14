using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_Ticaret_Süt_Ürünleri.Identify
{
    public class ApplicationUser: IdentityUser
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
    }
}