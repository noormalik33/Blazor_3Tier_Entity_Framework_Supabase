using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<ProductModel> _products = new()
        {
            new ProductModel { Id = Guid.NewGuid(), Name = "Product 1", Price = 10.99m, Category = "Category A" },
            new ProductModel { Id = Guid.NewGuid(), Name = "Product 2", Price = 19.99m, Category = "Category B" },
            new ProductModel { Id = Guid.NewGuid(), Name = "Product 3", Price = 5.99m, Category = "Category A" },
            new ProductModel { Id = Guid.NewGuid(), Name = "Product 4", Price = 15.99m, Category = "Category C" },

        };

        public void Add(ProductModel product)
        {
            _products.Add(product);
        }

        public void Delete(Guid id)
        {
            _products.RemoveAll(p => p.Id == id);
        }

        public List<ProductModel> GetAll()
        {
            return _products;
        }

        public ProductModel? GetById(Guid id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(ProductModel product)
        {
            var existingProduct = _products.FirstOrDefault(x => x.Id == product.Id);

            if (existingProduct == null)
            {
                return;
            }

            else
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Category = product.Category;
            }
        }
    }
 }


