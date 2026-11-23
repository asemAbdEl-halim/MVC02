using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC02.Entities
{
    public class Trainer : GymUser
    {
        public Specialties Specialty { get; set; } 
    }
}
