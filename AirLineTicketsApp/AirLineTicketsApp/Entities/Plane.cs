using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApp.Entities
{
    public class Plane
    {
        public Plane()
        {
            this.Flights = new HashSet<Flight>();
        }
        public int Id { get; set; }
        [Required]
        public int PlaneCode { get; set; }
        [Required]

        public string Model { get; set; }
        public string Picture { get; set; }
        [Required]
        [MaxLength(30)]
        public decimal Baggage { get; set; }

        public string Bar  { get; set; }
        public decimal Seats{ get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
