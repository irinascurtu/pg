using AutoMapper;
using PGShop.Domain.Entities;
using PGShop.Models;

namespace PGShop.Mappers
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryModel>();
        }
    }
}
