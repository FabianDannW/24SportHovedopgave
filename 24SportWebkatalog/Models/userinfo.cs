namespace _24SportWebkatalog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("easjtestside_dk_db.userinfo")]
    public partial class userinfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Fornavn skal være udfyldt")]
        [Display(Name = "Fornavn")]
        [StringLength(50)]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Efternavn skal være udfyldt")]
        [Display(Name = "Efternavn")]
        [StringLength(50)]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Email skal være udfyldt")]
        [EmailAddress(ErrorMessage = "Skriv venligst en gyldig email")]
        [Display(Name = "Email")]
        [StringLength(80)]
        public string email { get; set; }

        [Required(ErrorMessage = "Brugernavn skal være udfyldt")]
        [Display(Name = "Brugernavn")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Kodeord kan ikke være længere end 15 og kortere end 6.")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Kodeord skal være udfyldt")]
        [DataType(DataType.Password)]
        [Display(Name ="Kodeord")]
        [StringLength(15, MinimumLength =6, ErrorMessage ="Kodeord kan ikke være længere end 15 og kortere end 6.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Kodeord skal matche")]
        [DataType(DataType.Password)]
        [Display(Name = "Bekræft kodeord")]
        [StringLength(15, MinimumLength =6)]
        public string confirmpassword { get; set; }
    }
}
