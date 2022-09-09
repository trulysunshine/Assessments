using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Greetings
{
    internal class Doctor
    {
        public string name = Console.ReadLine();
        public string salary = Console.ReadLine();
        public void SayGreeting()
        {
            Console.WriteLine("Hello, I'm Dr. " + name);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
