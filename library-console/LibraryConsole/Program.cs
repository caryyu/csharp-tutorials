using System;
using Animal;

namespace LibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "CiCi";
            Console.WriteLine("Hello World! Dog is: {0}", dog.Name);
        }
    }
}
