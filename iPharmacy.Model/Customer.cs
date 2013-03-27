using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace iPharmacy.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}