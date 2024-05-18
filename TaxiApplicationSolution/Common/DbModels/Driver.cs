using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.DbModels
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public bool IsVerified { get; set; }

        public ICollection<Ride> Rides { get; set; }
    }
}
