using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Concept
{
    class Employee
    {
        public string Name;
        public string Email;
        public int ID;

        public Employee(string name, string email, int iD)
        {
            Name = name;
            Email = email;
            ID = iD;
        }
    }
}
