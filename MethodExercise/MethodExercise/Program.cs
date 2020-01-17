using System;
using System.Text.RegularExpressions;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("Name: " + name + "\n" + "Age: " + age + "\n" + "Favorite Color: " + color);

        }
      
    }
}
