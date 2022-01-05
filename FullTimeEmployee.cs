using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concept
{
    class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        public FullTimeEmployee(string Name, string Email, int ID, float YearlySalary) 

            : base(Name, Email, ID)
        {
            this.YearlySalary = YearlySalary;
        }
    }
}
