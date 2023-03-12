using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hostel.Models
{
    public partial class Rooms
    {
        public Rooms()
        {
            Comments = new HashSet<Comments>();
            Reservations = new HashSet<Reservations>();
        }

        public int IdRoom { get; set; }
        public string Title { get; set; }
        public int Capacity { get; set; }
        public int Comfort { get; set; }
        public int Cost { get; set; }
        public string Image { get; set; }
        public int IdStatus { get; set; }

        public virtual Statuses IdStatusNavigation { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
