using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public interface IProductService
    {
        List<ProductModel> GetAll();
        ProductModel? GetById(Guid id);
        void Create(ProductModel product);
        void Update(ProductModel product);
        void Delete(Guid id);
    }
}
