using EFDay15.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay15.Context
{
    public class FrontEnd_ReservationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source = .;Initial Catalog=FrontEnd_Reservation_New;Integrated Security=true;");
       
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
