using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.DbModels
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public int RideId { get; set; }

        [ForeignKey("RideId")]
        public Ride Ride { get; set; }

        [Required]
        public int RatingValue { get; set; }

        public string Comments { get; set; }
    }
}
