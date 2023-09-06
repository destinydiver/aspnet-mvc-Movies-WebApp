using MoviesWebApp.Data.Base;
using MoviesWebApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWebApp.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name="Name of Movie")]
        [Required(ErrorMessage ="Movie Name required")]
        public string? Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description required")]
        public string? Description { get; set; }

        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Price required")]
        public double Price { get; set; }

        [Display(Name = "Movie Poster URL")]
        [Required(ErrorMessage = "Poster image url is required")]
        public string? ImageURL { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start date required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End date required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Category")]
        [Required(ErrorMessage = "Movie Category is required")]
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage ="Movie actor(s) is required")]
        public List<int>? ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is required")]
        public int ProducerId { get; set; }
    }
}
