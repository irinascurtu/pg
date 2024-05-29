using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PGShop.Models
{
    public class SupplierModel
    {
        public int Supplierid { get; set; }

       
        public string Companyname { get; set; } = null!;

        public string Contactname { get; set; } = null!;


        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;
        
    }
}
