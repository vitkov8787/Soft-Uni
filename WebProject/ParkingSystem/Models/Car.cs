using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Brand")]
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Brand can only contain letters")]
        public string? Mark { get; set; }

        [DisplayName("Plate number")]
        [Required(ErrorMessage = "Plate number is required")]
        [RegularExpression(@"^[A-Z0-9]{1,7}$", ErrorMessage = "Invalid plate number format!")]
        public string? Plate { get; set; }
        [DisplayName("Time Added")]
        public DateTime TimeAdded { get; set; } = DateTime.Now;

        public DateTime ParkingStartTime { get; set; } = DateTime.Now;

        public const double HourlyRate = 1.2;

        public double Cost
        {
            get
            {
                return CalculateParkingCost();
            }
        }


        private double CalculateParkingCost()
        {
            TimeSpan span = DateTime.Now - ParkingStartTime;

            double hours = (int)span.TotalHours;


            return Math.Round(hours * HourlyRate, 2);
        }

    }
}