using Microsoft.AspNetCore.Mvc;

namespace Projekt.Models
{
    public class ClientInsuranceViewModel
    {
        public Client client;
        public Insurance insurance;
                
        public List<Insurance> Insurances { get; set; }

        
    }
}
