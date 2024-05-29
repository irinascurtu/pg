using Microsoft.EntityFrameworkCore;
using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly StoreContext context;

        public OrdersRepository(StoreContext context)
        {
            this.context = context;
        }


        public IQueryable<Order> GetAll()
        {
            return context.Orders;
        }
    }
}
