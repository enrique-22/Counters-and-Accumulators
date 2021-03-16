using System;

namespace Firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
          int a = 0, b = 0;

          Console.WriteLine("Enter a value for a:");

          a = Int32.Parse(Console.ReadLine());

          Console.WriteLine("Enter a value for  b:");
          
          b= Int32.Parse(Console.ReadLine());
          
          Console.WriteLine($"the multiplication is {a} * {b} = {MultiplyaNumber(a,b)}");
          //Console.WriteLine($"The sum is {a} + {b} = {AddNumbers(a,b)}");
          //Console.WriteLine($"The subtraction is {a} - {b} = {SubtractingaNumber(a,b)}");
           
        }

        /*public static int AddNumbers(int a , int b)
        {
            return a + b;
        }

        public static int SubtractingaNumber(int a, int b)
        {
           return a - b;
        }*/

        public static int MultiplyaNumber(int a, int b)
       {
           return a*b;
       }
    }
       
}