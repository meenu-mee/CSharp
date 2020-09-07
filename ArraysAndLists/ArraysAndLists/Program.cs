using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS-Length, sorting, foreach
            string[] cars = { "BMW", "Lambo", "Ford", "Audi" };
            Console.WriteLine(cars.Length);
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //LISTS-Add, Remove,
            var names = new List<string> { "Meenu", "John", "Daniel" };
            names.Add("Cole");
            names.Remove("John");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[1]} and {names[2]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");

            //Searching in a List
            var index = names.IndexOf("Daniel");
            if (index != -1) //i.e. if index of "Daniel" is found
                Console.WriteLine($"The name \"{names[index]}\" is at index {index}.");
            else
                Console.WriteLine($"The name \"{names[index]}\" is not present in list.");


            //Sorting a List
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


        }
    }
}
