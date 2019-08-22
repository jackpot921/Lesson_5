using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_3
{
    class Cat
    {
        public string Name;
        public int Age;

        public void Voice()
        {
            Console.WriteLine($"Meow! My name is {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat catBob = new Cat();
            catBob.Name = "Bob";
            catBob.Age = 3;

            Cat catJohn = new Cat();
            catJohn.Name = "John";
            catJohn.Age = 1;

            catBob.Voice();
            catJohn.Voice();
        }
    }
}
