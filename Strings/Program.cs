using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Length of string
            string friend1 = "John";
            string friend2 = "Lilly";
            Console.WriteLine($"They are {friend1} and {friend2}.");
            Console.WriteLine($"{friend1} has {friend1.Length} letters.");
            Console.WriteLine($"{friend2} has {friend2.Length} letters.");

            //TrimStart(), TrimEnd(), Trim()
            string cheese = "      Say Cheese!       ";
            Console.WriteLine($"[{cheese}]");

            string trimmedCheese = cheese.TrimStart();
            Console.WriteLine($"[{trimmedCheese}]");

            trimmedCheese = cheese.TrimEnd();
            Console.WriteLine($"[{trimmedCheese}]");

            trimmedCheese = cheese.Trim();
            Console.WriteLine($"[{trimmedCheese}]");

            //Replace()
            string sayHi = "Hi, Daniel Caesar!";
            Console.WriteLine(sayHi);

            sayHi = sayHi.Replace("Caesar", "Brown");
            Console.WriteLine(sayHi);

            Console.WriteLine(sayHi.ToUpper());
            Console.WriteLine(sayHi.ToLower());
            Console.WriteLine(sayHi);
        }
    }
}


















