using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class TourGroup
    {
        [Key]
        public int TourGroupId { get; set; }
        [Required]
        public string TourName { get; set; }
        [Required]
        public int TourSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
