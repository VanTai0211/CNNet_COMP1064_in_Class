using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B1_CNNet_COMP1064_in_Class.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total => Price * Quantity;
    }
}
