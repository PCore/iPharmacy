using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace iPharmacy.Model
{
    public class License
    {
        [Key]
        public int LicenseNumber { get; set; }
        
    }
}