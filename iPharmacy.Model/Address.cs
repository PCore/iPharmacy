using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace iPharmacy.Web.Models
{
 
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Country { get; set; }
    }
   
}