using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBill.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public int ItemIndex { get; set; }
    }
}