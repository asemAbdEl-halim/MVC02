using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string email { get; set; } = default!;
        public string phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; } = default!;
    }
}
