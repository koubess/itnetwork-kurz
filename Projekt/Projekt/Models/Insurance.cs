using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt.Models
{
    public class Insurance
    {
        public int Id { get; set; }
       
        [ForeignKey("Client")]
        [Display(Name = "Id pojištěnce")]
        public int ClientId { get; set; } = 0;
        [Display(Name = "Pojištěnec")]
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Vyplňte Pojištění")]
        [Display(Name ="Pojištění")]
        public string InsuranceType { get; set; } = "";

        [Required(ErrorMessage = "Vyplňte částku")]
        [Display(Name = "Částka")]
        public decimal InsurancePrice { get; set; } = 0;

        [Required(ErrorMessage = "Vyplňte předmět pojištění")]
        [Display(Name = "Předmět pojištění")]
        public string InsuredObject { get; set; } = "";

        [Required(ErrorMessage ="Vyplňte datum začátku pojistky")]
        [Display(Name ="Platnost od")]
        [DataType(DataType.Date)]
        public DateTime InsuredFrom { get; set; }

        [Required(ErrorMessage ="Vyplňte datum konce pojistky")]
        [Display(Name = "Platnost do")]
        [DataType(DataType.Date)]
        public DateTime InsuredTo { get; set;}


    }
}
