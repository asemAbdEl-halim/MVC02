using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        public ICollection<Membership> MemberSubscription { get; set; } = default!;
    }
}
