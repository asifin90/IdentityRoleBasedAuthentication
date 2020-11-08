using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;


namespace Identity_Employee.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        //[Remote(action:"IsEmailInUse", controller:"Account")]
        public string Email{ get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Password and Confirm password not matched")]
        public string ConfirmPassword { get; set; } 

    }
}
