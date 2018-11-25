using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlineshipping.Models
{
    public class Items
    {
        public String Name { get; set; }
        public int Price { get; set; }
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int Produces_ID { get; set; }
        public Produces Produces_Pro { get; set; }
    }
}
        