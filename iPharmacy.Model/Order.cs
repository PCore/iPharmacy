using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iPharmacy.Web.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }

    }
}