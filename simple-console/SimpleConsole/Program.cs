using System;

namespace simple_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "KiKi";
            dog.Gender = "Male";
            Console.WriteLine("Hello World! The Dog is: {0}", dog.Name);
        }
    }

    class Dog
    {
      public String Name {set;get;}
      public String Gender {set;get;}
    }
}
