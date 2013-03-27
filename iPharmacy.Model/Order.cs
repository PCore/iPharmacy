using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace iPharmacy.Model
{
    public class Order
    {   
        [Key]
        public int OrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        

    }
}