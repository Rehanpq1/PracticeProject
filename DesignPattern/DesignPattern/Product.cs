using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Discount { get; set; }

        public decimal Couple { get; set; }

        public decimal DeliveryCharge { get; set; }

        public bool ReturnAllow { get; set; }

    }
    
}

