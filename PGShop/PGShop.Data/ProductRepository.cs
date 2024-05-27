using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext context;

        public ProductRepository(StoreContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetAll()
        {
            return context.Products;
        }

        public Product GetById(int id)
        {
            return context.Products.FirstOrDefault(x => x.Productid == id);
        }
    }
}
