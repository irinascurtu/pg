using Microsoft.EntityFrameworkCore;
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
            return context.Products
                .Include(x => x.Supplier)
                .Include(x => x.Category);

        }


        public Product GetById(int id)
        {
            return context.Products.FirstOrDefault(x => x.Productid == id);
        }

        public IQueryable<Product> GetProductsRaw(int categoryId)
        {
            //var query = @"select * from Products p
            //            join Suppliers s on  s.supplierid =p.supplierid
            //            where p.categoryid=1";

            var query = @"select p.productid, p.categoryid,p.unitprice, p.discontinued, p.productname, s.* from Products p
                    inner join Suppliers s on  s.supplierid = p.supplierid
                    where p.categoryid=1";

            return context.Products.FromSqlRaw<Product>(query);
        }
    }
}
