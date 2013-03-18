using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iPharmacy.Web.Models
{
    public class ShoppingCart
    {
        public List<Products> SelectedProducts { get; set; }
    }
}