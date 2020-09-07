using System;

namespace NumbersAndDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basics
            int a = 18;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);            
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c); 
            c = a / b;
            Console.WriteLine(c); //3
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = (a + b) / c;
            int f = (a + b) % c;
            Console.WriteLine($"quotient: {e}");
            Console.WriteLine($"remainder: {f}");

            //INTEGERS
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            //DOUBLE
            double max_d = double.MaxValue;
            double min_d = double.MinValue;
            Console.WriteLine($"The range of double is {min_d} to {max_d}");

            //DECIMAL: greater precision than double
            decimal min_deci = decimal.MinValue;
            decimal max_deci = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min_deci} to {max_deci}");

            decimal g = 1.0M;
            decimal h = 3.0M;
            Console.WriteLine(g / h);
        }
    }
}
