using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 4;
            //IF-ELSE
            if ((a + b + c > 10) && (a == b)) //Using logical operator
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            //WHILE LOOP
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            //DO-WHILE
            int counter1 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter1}");
                counter1++;
            } while (counter1 < 4);

            //FOR LOOP
            for (int counter2 = 0; counter2 < 3; counter2++)
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
            }

            //NESTED LOOP
            for (int row = 1; row < 3; row++)
            {
                for (char column = 'a'; column < 'd'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            //Sum of nos divisible by 3
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine($"The sum is {sum}");

        }
    }
}
