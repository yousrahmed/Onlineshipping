using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlineshipping.Models
{
    public class Produces
    {
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public List<Order> Olist1 { get => Olist; set => Olist = value; }

        private List<Order> Olist;

        public List<Order> GetOlist()
        {
            return Olist1;
        }
    }
}