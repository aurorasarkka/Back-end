using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationSystem.Models
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) 
            : base(options)
        { 
        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
