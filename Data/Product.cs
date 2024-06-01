using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalAECApp.Data
{
    [Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }
        [ForeignKey("Farmer")]
        public int FarmerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateOnly ProductionDate { get; set; }

        // Navigation property
        public Farmer Farmer { get; set; }
    }
}
