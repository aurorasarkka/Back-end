using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class Reservation
    {
        public long Id { get; set; }
        public Item Target {get; set;}
        public User Owner { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
