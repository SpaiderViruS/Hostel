using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hostel.Models
{
    public partial class Users
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Reservations = new HashSet<Reservations>();
        }

        public int IdUser { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronomyc { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }

        public virtual Roles IdRoleNavigation { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
