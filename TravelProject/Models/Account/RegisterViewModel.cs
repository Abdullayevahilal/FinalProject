using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Travel.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="This field is required")]
        [MaxLength(50,ErrorMessage = "The text entered exceeds the maximum length")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50, ErrorMessage = "The text entered exceeds the maximum length")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50, ErrorMessage = "The text entered exceeds the maximum length")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50, ErrorMessage = "The password entered exceeds the maximum length")]
        [MinLength(6, ErrorMessage = "The password entered is too short")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(50, ErrorMessage = "The password entered exceeds the maximum length")]
        [MinLength(6, ErrorMessage = "The password entered is too short")]
        [Compare("Password",ErrorMessage ="Those passwords didn't match.Try again")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

    }
}
