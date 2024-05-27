using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Data
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();
        Product GetById(int id);
    }
}
