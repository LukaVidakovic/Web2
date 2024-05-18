using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.DbModels
{
    public class Ride
    {
        [Key]
        public int RideId { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int? DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [Required]
        public string StartAddress { get; set; }

        [Required]
        public string EndAddress { get; set; }

        public decimal Price { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public RideStatus Status { get; set; }
    }

    public enum RideStatus
    {
        Pending,
        Accepted,
        Completed,
        Canceled
    }
}
