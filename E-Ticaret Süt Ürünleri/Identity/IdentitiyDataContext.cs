using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Ticaret_Süt_Ürünleri.Identify;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_Ticaret_Süt_Ürünleri.Identity
{
    public class IdentitiyDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentitiyDataContext() : base ("dataConnection")
        {
            
        }
    }
}