using FinalAECApp.Data;
using System.ComponentModel;

namespace FinalAECApp.Models
{
    public class FarmerViewModel
    {
        public int FarmerId { get; set; }
        [DisplayName("First Name")]
        public string Name { get; set; }
        [DisplayName("Surame")]
        public string Surname { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Name")]
        public string FullName
        {
            get { return Name + " " + Surname; }
        }

        // Navigation property to represent the relationship
        //public ICollection<Product> Products { get; set; }
    }
}
