using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class UserDTO
    {
        public long Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public String UserName { get; set; }
        [MaxLength(25)]
        public String FirstName { get; set; }
        [MaxLength(25)]
        public String LastName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
