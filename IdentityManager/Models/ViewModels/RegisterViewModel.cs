using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="The {0} is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The {0} is required!")]
        [EmailAddress(ErrorMessage ="The {0} is not valid!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "The {0} is required!")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="The Password and ConfirmPassword are not match!")]
        public string ConfirmPassword { get; set; }
    }
}
