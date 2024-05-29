using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Data
{
    public interface IOrdersRepository
    {
        IQueryable<Order> GetAll();
    }
}
