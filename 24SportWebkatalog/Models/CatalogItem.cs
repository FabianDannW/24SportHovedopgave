using System.ComponentModel.DataAnnotations;

namespace _24SportWebkatalog.Models
{
    public class CatalogItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Please submit a name for the product")]
        public string ItemName { get; set; }

        public string ImgPath { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please submit a price for the product")]

        public double Price { get; set; }
    }
}