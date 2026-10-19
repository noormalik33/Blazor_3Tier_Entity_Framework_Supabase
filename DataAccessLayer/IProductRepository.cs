using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IProductRepository
    {
        List<ProductModel> GetAll();

        ProductModel? GetById(Guid id);

        void Add(ProductModel product);

        void Update(ProductModel product);
        
        void Delete(Guid id);
    }
}
