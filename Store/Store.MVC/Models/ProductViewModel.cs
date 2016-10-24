using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.MVC.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }
    }
}