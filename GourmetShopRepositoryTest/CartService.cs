using GourmetShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetShopRepositoryTest
{
    public class CartService
    {
        // List
        private List<Product> _products;

        public CartService()
        {
            _products = new List<Product>();
        }

        //add
        public void Add(Product product)
        {
            _products.Add(product);
        }

        //delete
        public void Delete(Product item)
        {
            _products.Remove(item);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product? GetProductbyID(int id)
        {
            var product = _products.Where(p => p.ProductID == id).FirstOrDefault();
            return product;
        }

        public int Count()
        {
            return _products.Count;
        }

    }
}
