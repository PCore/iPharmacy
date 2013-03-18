using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iPharmacy.Web.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFormulation { get; set; }
        public string AvailableQuantity { get; set; }
        public string AllocatedQuantity { get; set; }
        public string NextAvailOrderDate { get; set; }
        public string OTC { get; set; }
        public string Regulated { get; set; }
    }
}