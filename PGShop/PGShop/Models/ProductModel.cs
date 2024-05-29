using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PGShop.Domain.Entities;

namespace PGShop.Models
{
    public class ProductModel
    {
        public int Productid { get; set; }

        public string Productname { get; set; } = null!;

        public decimal Unitprice { get; set; }
        public bool Discontinued { get; set; }

        public SupplierModel Supplier { get; set; } = null!;
    }
}
