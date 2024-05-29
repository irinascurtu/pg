using AutoMapper;
using PGShop.Domain.Entities;
using PGShop.Models;

namespace PGShop.Mappers
{
    public class OrdersProfile : Profile
    {
        public OrdersProfile()
        {
            //createmaps
            CreateMap<Order, OrderModel>();
        }
    }
}
