using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02.Entities
{
    public class Membership : BaseEntity
    {
        public int MemberId { get; set; } // FK
        public Member Member { get; set; } 
        public int PlanId { get; set; } // FK
        public Plan Plan { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Column Status [Not a Column in a DataBase]
        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";
    }
}
