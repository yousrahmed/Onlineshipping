using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlineshipping.Models
{
    public class Craditcarrd
    {
        public int Card_id { get; set; }
        public string C_name { get; set; }
        public string C_address { get; set; }
        public int C_Number { get; set; }
        public int Vcs { get; set; }
        public String Expirydate { get; set; }
        public List<Customer> Clist { get; set; }
    }
}