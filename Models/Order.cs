using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Onlineshipping.Models
{
    public class Order
    {
        [Required]

        public int Order_ID { get; set; }
        [StringLength(50, ErrorMessage = "limited")]
        public string Quality { get; set; }
        public int Price { get; set; }
        public int Shippingcost { get; set; }
        public List<Produces> Plist { get; set; }
        public List<Items> Ilist { get; set; }
    }
}