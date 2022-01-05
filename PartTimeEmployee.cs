using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concept
{
    class PartTimeEmployee : Employee
    {
        public float HourPaid;

        public PartTimeEmployee(string Name, string Email, int ID, float HourPaid) 

            : base(Name, Email, ID)
        {
            this.HourPaid = HourPaid;
        }
    }
}
