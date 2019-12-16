using Microsoft.AspNetCore.Identity;

namespace GuldtandMVC_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}