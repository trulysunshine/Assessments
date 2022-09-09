using System;
using System.IO;
using System.IO.Pipes;
using System.Xml.Linq;

namespace Greetings
{
    class Person
    {
        public string name = Console.ReadLine();
        public string phone = Console.ReadLine();
        public string email = Console.ReadLine();
        public void SayGreeting()
        {
            Console.WriteLine("Hello, I'm " + name);
            Console.WriteLine("Phone Number: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}