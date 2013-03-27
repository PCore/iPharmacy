using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iPharmacy.Model;

namespace iPharmacy.Domain
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }

}
