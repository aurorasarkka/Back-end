using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class Item
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public User Owner { get; set; }
    }
}
