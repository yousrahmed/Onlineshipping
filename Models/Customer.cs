using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlineshipping.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string E_Mail { get; set; }
        public int C_ID { get; set; }
        public Craditcarrd Creditcard { get; set; }
    }
}