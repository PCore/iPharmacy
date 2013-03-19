using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iPharmacy.Web.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Formulation { get; set; }
        public string AvailableQuantity { get; set; }
        public string NextAvailOrderDate { get; set; }
        public string OTC { get; set; }
        public string Regulated { get; set; }
    }
}