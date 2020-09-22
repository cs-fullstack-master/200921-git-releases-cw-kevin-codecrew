using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class ProductModel
    {
        [Key]
        public int id{get;set;}
        [Display(Name = "Name")]
        public string productName{get;set;}
        [Display(Name = "Price")]
        public int price{get;set;}
        [Display(Name = "Quantity")]
        public int quantity{get;set;}
    }
}