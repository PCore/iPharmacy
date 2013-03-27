using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using iPharmacy.Model;
using iPharmacy.Domain;

namespace iPharmacy.Domain
{
    public class ProductRepository : IProductRepository, IDisposable
    {
        private iPharmacyDb context;

        public ProductRepository()
        {
            this.context = new iPharmacyDb();
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductByID(int id)
        {
            return context.Products.Find(id);
        }

        public void InsertProduct(Product product)
        {
            context.Products.Add(product);
        }

        public void DeleteProduct(int productID)
        {
            Product product = context.Products.Find(productID);
            context.Products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
