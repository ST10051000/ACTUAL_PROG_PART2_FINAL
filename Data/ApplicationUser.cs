using Microsoft.AspNetCore.Identity;

namespace FinalAECApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
