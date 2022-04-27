using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class User
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
        [Required]
        public String PassWord { get; set; }
        public byte[] salt { get; set; }
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
        

    }
}
