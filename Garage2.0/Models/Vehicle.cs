using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
      
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Required]
        public int VehicleTypeId { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public string Colour { get; set; }
        public string Brand { get; set; } 
        public string Model { get; set; }
        [Range(0, 16)] 
        public int WheelCount { get; set; }
        [Editable(false)]
        public DateTime ParkTime { get; set; }
        public int ParkingLot { get; set; }

        public virtual VehicleType Type { get; set; }
        public virtual Member Member { get; set; }

    }

    //public enum Type 
    //{
    //    Bil,       
    //    Båt,
    //    Buss,
    //    Flygplan,
    //    Lastbil,
    //    Motorcykel
    //}

}