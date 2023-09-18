using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class Client
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Zadejte jméno ")]
        [Display(Name="Jmeno")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Zadejte příjmení")]
        [Display(Name = "Příjmení")]
        public string Surname { get; set; } = "";

        [Required(ErrorMessage ="Zadejte Email")]
        [EmailAddress(ErrorMessage ="Neplatná emailova adresa")]
        [Display(Name="Email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage ="Zadejte telefon")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefonní číslo")]
        public string PhoneNumber { get; set; } = "";

        [Required(ErrorMessage ="Zadejte město")]
        [Display(Name="Město")]
        public string City { get; set; } = "";

        [Required(ErrorMessage ="Zadejte adresu")]
        [Display(Name="Adresa")]
        public string Adress { get; set; } = "";

        [Required(ErrorMessage = "Zadejte Poštovní směrovací číslo")]
        [Display(Name = "Psč")]
        public int Psc { get; set; } = 0;

    }
}
