using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Game_Store.Models
{
    public class Game
    {
        // EF will instruct the database to automatically generate this value
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2050, ErrorMessage = "Year must be between 1889 and now.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter the cost.")]
        [Range(0, 200, ErrorMessage = "Rating must be between 1 and 5.")]
        public double? Cost { get; set; }

    }
}