using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    internal class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.SayGreeting();
            Doctor doctor = new Doctor();
            doctor.SayGreeting();
        }
    }
}
