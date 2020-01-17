using System;
using System.Text.RegularExpressions;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("Name: " + name + "\n" + "Age: " + age + "\n" + "Favorite Color: " + color);
            string[] array = new string[5]; */
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            string num = (arr.ToString());

            Console.WriteLine(num);

        }
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach(int a in arr)
            {
                sum += a;
            }
            return sum;
        }
        public static int Product(params int[] arr)
        {
            int product = 1;
            foreach (int a in arr)
            {
                product *= a;
            }
            return product;
        }
        public static int Difference(params int[] arr)
        {
            int difference = arr[0];
            for(int j = 1; j < arr.Length; j++)
            {
                difference = difference - arr[j];
            }
            return difference;
        }
        public static int Quotient( params int[] arr)
        {
            int quotient = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                quotient = quotient / arr[i];
            }
            return quotient;
        }
        public static int Mod(params int[] arr)
        {
            int mod = arr[0];
            for(int k = 1; k < arr.Length; k++)
            {
                mod = mod % arr[k];
            }
            return mod;
        }
      
    }
}
