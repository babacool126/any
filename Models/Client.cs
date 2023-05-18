using System.ComponentModel.DataAnnotations;
using MyCVKetel_Project.Models;


namespace MyCVKetel_Project.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string NumeroDeTelephone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Adresse { get; set; }

        public ICollection<Problem> Problems { get; set; }
        public ICollection<RendezVous> RendezVous { get; set; }
    }
}
