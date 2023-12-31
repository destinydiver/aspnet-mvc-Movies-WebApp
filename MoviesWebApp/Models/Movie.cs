﻿using MoviesWebApp.Data.Base;
using MoviesWebApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesWebApp.Models
{
    public class Movie : IEntityBase
    {
        [Key]
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

        [Display(Name = "Movie Poster")]
        [Required(ErrorMessage = "Poster image required")]
        public string? ImageURL { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start date required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Genre")]
        [Required(ErrorMessage = "Genre required")]
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
        public Cinema? Cinema { get; set; }

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }
    }
}
