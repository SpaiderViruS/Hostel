using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hostel.Models
{
    public partial class Reservations
    {
        public int IdReservation { get; set; }
        public int? IdUser { get; set; }
        public int? IdRoom { get; set; }
        public int IdStatusReservation { get; set; }
        public DateTime? SettlementDate { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual Rooms IdRoomNavigation { get; set; }
        public virtual Statuses IdStatusReservationNavigation { get; set; }
        public virtual Users IdUserNavigation { get; set; }
    }
}
