using System;
using System.Collections.Generic;

namespace FibonacciNo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new List<int> { 1, 1 } ;

            while(fibonacci.Count < 20)
            {
                var a = fibonacci[fibonacci.Count - 2] ;
                var b = fibonacci[fibonacci.Count - 1];
                fibonacci.Add(a + b);

            }
            foreach(var num in fibonacci)
            {
                Console.WriteLine(num);
            }
        }
    }
}
