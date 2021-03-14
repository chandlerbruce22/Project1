using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        [Required]
        public DateTime TourTime { get; set; }
        public List <TourGroup> Groups { get; set; }
        public void AddTourGroup (TourGroup group)
        {
            Groups.Add(group);
        }
    }
}
