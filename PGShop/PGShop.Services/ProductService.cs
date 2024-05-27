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

        public ProductService( IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IQueryable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.GetById(id);
        }
    }
}
