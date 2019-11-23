using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiKiemTra2.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SupplierID { get; set; }
        public string Picture { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public double price { get; set; }


    }
}