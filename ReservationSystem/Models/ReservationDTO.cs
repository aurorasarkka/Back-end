using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class ReservationDTO
    {
        public long Id { get; set; }
        public long Target { get; set; }
        public String Owner { get; set; }
        public DateTime Start {get; set;}
        public DateTime End { get; set; }
    }
}
