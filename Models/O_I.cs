using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlineshipping.Models
{
    public class O_I
    {
        public int O_ID { get; set; }
        public Order Order_O { get; set; }
        public int I_ID { get; set; }
        public Items Items_I { get; set; }
    }
}