using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_Ticaret_Süt_Ürünleri.Identify
{
    public class ApplicationRole : IdentityRole
    {
        public string Aciklama { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolname , string aciklama)
        {
            this.Aciklama = aciklama;
        }
    }
}