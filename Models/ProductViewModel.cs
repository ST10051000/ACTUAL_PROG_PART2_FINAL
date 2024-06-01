using FinalAECApp.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalAECApp.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        //[ForeignKey("Farmer")]
        public int FarmerId { get; set; }
        [DisplayName("First Name")]
        public string Name { get; set; }
        [DisplayName("Category")]
        public string Category { get; set; }
        [DisplayName("Production Date")]
        public DateOnly ProductionDate { get; set; }

        // Navigation property
        //public Farmer Farmer { get; set; }
    }
}
