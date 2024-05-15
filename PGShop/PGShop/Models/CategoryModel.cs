using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PGShop.Models
{
    public class CategoryModel
    {

        public int Categoryid { get; set; }

        [StringLength(15)]
        public string Categoryname { get; set; } = null!;


        [StringLength(200)]
        public string Description { get; set; } = null!;
    }
}
