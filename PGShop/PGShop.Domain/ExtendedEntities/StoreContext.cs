using Microsoft.EntityFrameworkCore;
using PGShop.Domain.ExtendedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGShop.Domain.Entities
{
    public partial class StoreContext
    {
        public virtual DbSet<MyProduct> MyProducts { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyProduct>().HasNoKey();
        }
    }
}
