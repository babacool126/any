using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyCVKetel_Project.Models
{
    public class RendezVous
    {
        [Key]
        public int RendezVousId { get; set; }

        [Required]
        public DateTime Jour { get; set; }

        [Required]
        public TimeSpan Heure { get; set; }

        public string Remarque { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
