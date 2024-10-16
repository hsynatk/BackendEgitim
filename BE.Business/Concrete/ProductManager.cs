using BE.Business.Abstract;
using BE.DataAccess.Abstract;
using BE.Entities.Concrete;
using System.Collections.Generic;

namespace BE.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
           return _productDal.GetAll();
        }
    }
}
