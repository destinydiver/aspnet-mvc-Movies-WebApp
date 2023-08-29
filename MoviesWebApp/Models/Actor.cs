using MoviesWebApp.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MoviesWebApp.Models
{
    public class Actor : IEntityBase
    {
        // Can remove the Key/Id below because now have class inheriting from
        // IEntityBase who's Id/Key will override this Key
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture Is Required!")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name Is Required!")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography Is Required!")]
        public string? Bio { get; set; }

        // Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }

}
