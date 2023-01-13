using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineTicketsApp.Entities
{
    public class Flight
    {
        public Flight()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        [Required]
        public int FlysNumber { get; set; }
        [Required]

        public string StartDestination { get; set; }
        [Required]
        public string EndDestination { get; set; }
        [Required]
        public DateTime DateFly { get; set; }
        public DateTime DateLoading { get; set; }

        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        [Required]

        public decimal TicketsPrice { get; set; }

        public decimal Percentage { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
