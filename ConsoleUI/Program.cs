﻿

using BE.Business.Concrete;
using BE.DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new InMemoryProductDal());


    foreach (var product in productManager.GetAll())
    {
        Console.WriteLine(product.ProductName);
    }
