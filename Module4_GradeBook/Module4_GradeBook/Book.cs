using System;
using System.Collections.Generic;
using System.Text;

namespace Module4_GradeBook
{
    public class Book
    {
        private List<double> grades ;
        private string name;
        public Book (string name)
        {
            grades = new List<double>();
            this.name = name;

        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics ShowStatistics()
        {
            var result = new Statistics(); 
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var number in grades)
            {
                result.Average += number;
                result.High = Math.Max(number, result.High);
                result.Low = Math.Min(number, result.Low);
            }
            result.Average /= grades.Count;

          return result;

        }

    }
}
