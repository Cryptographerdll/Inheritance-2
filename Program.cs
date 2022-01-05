using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inheritance_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee ep = new PartTimeEmployee("amine", "amine@gmail.com", 4, 30F);
            FullTimeEmployee ep_ = new FullTimeEmployee("khalil", "khalil@gmail.com", 12, 5000F);
            Employee ep__ = new PartTimeEmployee("emma", "emma@gmail.com", 7, 20000F);

            baseClass e = new Agent("Emma","4");
           ((Agent)e).DisplayNom();
        }
    }

    class baseClass
    {
        public string name;

        public void DisplayNom()
        {
            Console.WriteLine($"base {name}");
        }

        public baseClass(string Name)
        {
            this.name = Name;
        }
    }

    class Agent : baseClass
    {
        public string Id;

        public Agent(string Name, string id) : base(Name)
        {
            this.Id = id;
        }

        public new void DisplayNom()
        {
            Console.WriteLine("child le nom est: {0}", this.name);
        }
    }
}
