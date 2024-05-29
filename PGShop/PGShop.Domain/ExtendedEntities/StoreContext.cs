using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Domain.ExtendedEntities
{
    public partial class StoreContext
    {
        public virtual DbSet<MyProduct> MyProducts { get; set; }
    }
}
