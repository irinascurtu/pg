using AutoMapper;
using PGShop.Domain.Entities;
using PGShop.Models;

namespace PGShop.Mappers
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Supplier, SupplierModel>();
            CreateMap<Product, ProductModel>();
        }
    }
}
