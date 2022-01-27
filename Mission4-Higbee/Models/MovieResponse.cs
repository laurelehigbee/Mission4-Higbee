using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission4_Higbee.Models
{
    public class MovieResponse //Model for the Movie response form
    {
        [Key] //assigns the MovieSubmissionID as the primary key
        [Required] //required input
        public int MovieSubmissionId { get; set; } 
        [Required]  //required input
        public string Category { get; set; }
        [Required] //required input
        public string Title { get; set; }
        [Required]//required input
        public int Year { get; set; }
        [Required] //required input
        public string Director { get; set; }
        [Required] //required input
        public string Rating { get; set; }
        public bool Edited { get; set; } //this is a boolean (true/false)
        public string Lent_to {get;set;}

        [MaxLength(25)] //notes can only be 25 characters long
        public string Notes { get; set; }


    }
}

