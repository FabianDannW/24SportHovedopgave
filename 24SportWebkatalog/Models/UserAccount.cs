using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _24SportWebkatalog.Models
{
    public class UserAccount
    {
        [Key]

        public int UserID { get; set; }

        [Required(ErrorMessage ="First Name is required")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string lastname { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Please enter a valid email.")]
        public string email { get; set; }

        [Required(ErrorMessage ="Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage ="password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Please confirm your password")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }

    }
}