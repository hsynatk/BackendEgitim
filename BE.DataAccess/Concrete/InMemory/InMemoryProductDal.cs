using BE.DataAccess.Abstract;
using BE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() { 
             new Product{ProductId=1,CategoryId=1,ProductName="Lenovo Log",UnitPrice=3500,UnitInStock=20},
             new Product{ProductId=2,CategoryId=1,ProductName="Iphone 16",UnitPrice=6800,UnitInStock=18},
            };
        }
        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete =productToDelete=_products.FirstOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
           return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.CategoryId = product.CategoryId;

        }
    }
}
