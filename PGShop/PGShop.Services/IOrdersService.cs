using PGShop.Domain.Entities;

namespace PGShop.Services
{
    public interface IOrdersService
    {
        IQueryable<Order> GetAll();
    }
}