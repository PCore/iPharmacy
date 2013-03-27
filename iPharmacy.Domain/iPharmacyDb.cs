using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using iPharmacy.Model;

namespace iPharmacy.Domain
{
    public class iPharmacyDb : DbContext
    {
        public iPharmacyDb()
            : base("name=IPharmacyConnection")
        {
        }


        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
