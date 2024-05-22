using PGShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Services
{
    public interface ICategoryService
    {
        bool CheckIfExists(int id);
        Category GetCategory(int id);
    }
}
