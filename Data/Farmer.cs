using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalAECApp.Data
{
    [Table("Farmer")]
    public class Farmer
    {
        public int FarmerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        // Navigation property to represent the relationship
        public ICollection<Product> Products { get; set; }
    }
}
