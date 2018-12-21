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
        [Display(Name = "Produktnavn")]
        public string ItemName { get; set; }

        [StringLength(500)]
        [Display(Name = "Billede")]
        public byte[] ImgPath { get; set; }

        [StringLength(500)]
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }

        [Display(Name = "Pris")]
        public double Price { get; set; }
    }
}