using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Enter a valid username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password field cannot be blank!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password and Verify Password fields must match")]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }
    }
}
