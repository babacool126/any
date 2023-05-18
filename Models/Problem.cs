using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyCVKetel_Project.Models
{
    public class Problem
    {
        [Key]
        public int ProblemId { get; set; }

        [Required]
        public string Kind { get; set; } // 'reparation' ou 'entretien'

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
