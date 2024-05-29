using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PGShop.Models
{
    public class OrderModel
    {
        public int Orderid { get; set; }


        public int? Custid { get; set; }

        public int Empid { get; set; }


        public DateOnly Orderdate { get; set; }

        public DateOnly Requireddate { get; set; }

        public DateOnly? Shippeddate { get; set; }

        public int Shipperid { get; set; }


        public decimal Freight { get; set; }


        public string Shipname { get; set; } = null!;


        public string Shipaddress { get; set; } = null!;

        public string Shipcity { get; set; } = null!;

        public string? Shipregion { get; set; }

        public string? Shippostalcode { get; set; }

        public string Shipcountry { get; set; } = null!;
    }
}
