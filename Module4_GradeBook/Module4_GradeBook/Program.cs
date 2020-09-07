using System;

namespace Module4_GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Student1 Grade Book");
           // book.AddGrade(88.6);
            book.AddGrade(76.1);
            book.AddGrade(87.1);
            book.AddGrade(93.9);
           // book.AddGrade(90.6);
            var stats = book.ShowStatistics(); //returns Statistics object

            Console.WriteLine($"Average is {stats.Average}");
            Console.WriteLine($"highest Grade is {stats.High}");
            Console.WriteLine($"Lowest Grade is {stats.Low}");
        }
    }
}
