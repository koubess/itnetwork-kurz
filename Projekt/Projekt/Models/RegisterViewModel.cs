using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Vyplňte emailovou adresu")]
        [EmailAddress(ErrorMessage = "Neplatna emailova adresa")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Vyplňte heslo")]
        [StringLength(100, ErrorMessage = "{0} musí mít delku alespoň {2} a nejvíce {1} znaku.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vypnlňte heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Pozvrzení hesla")]
        [Compare(nameof(Password), ErrorMessage = "Zadaná hesla se musí shodovat.")]
        public string ConfirmPassword { get; set;}
    }
}
