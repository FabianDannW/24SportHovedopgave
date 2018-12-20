using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _24SportWebkatalog.Models
{
    [Table("easjtestside_dk_db.catalogInfo")]
    public partial class CatalogItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string ItemName { get; set; }

        [StringLength(500)]
        public byte[] ImgPath { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        
        public double Price { get; set; }
    }
}