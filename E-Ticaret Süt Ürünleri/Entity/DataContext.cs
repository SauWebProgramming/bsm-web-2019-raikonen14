using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using E_Ticaret_Süt_Ürünleri.Identify;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_Ticaret_Süt_Ürünleri.Entity
{
    public class DataContext:DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Katagori> Katagoriler { get; set; }
    }
}