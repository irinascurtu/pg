using PGShop.Data;
using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public Product GetProduct(int id)
        {
            return productRepository.GetById(id);
        }

        public IQueryable<Product> GetProducts()
        {
            var products = productRepository.GetAll();
            return products;
        }

        public IQueryable<Product> GetProducts(int categoryId)
        {
            return productRepository.GetProductsRaw(categoryId);
            //var products = productRepository.GetAll();
            //  return GetProducts().Where(x => x.Categoryid == categoryId);
        }



    }
}
