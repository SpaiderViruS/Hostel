using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hostel.Models
{
    public partial class Statuses
    {
        public Statuses()
        {
            Reservations = new HashSet<Reservations>();
            Rooms = new HashSet<Rooms>();
        }

        public int IdStatus { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
