using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace OnlineShop.Shared
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string Image { get; set; }
        public int Stars { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
    }
}
