using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiKiemTra2.Models
{

    public class MyDbContext : DbContext
    {
        public System.Data.Entity.DbSet<BaiKiemTra2.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<BaiKiemTra2.Models.Product> Products { get; set; }
    }
}