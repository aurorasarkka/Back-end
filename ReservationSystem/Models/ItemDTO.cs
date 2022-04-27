using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class ItemDTO
    {
        public long Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public String Name { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public String Owner { get; set; }


    }
}
