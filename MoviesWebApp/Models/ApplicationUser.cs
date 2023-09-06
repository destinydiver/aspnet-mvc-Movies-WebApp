using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // FullName property added in addition to the already included fields in the "IdentityUser" namespace
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
    }
}
