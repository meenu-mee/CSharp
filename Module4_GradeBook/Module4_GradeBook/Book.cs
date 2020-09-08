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
            if (grade<=100 && grade>=0)
            {
                grades.Add(grade);
            }
            else
            {
                //Console.WriteLine("Invalid value");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }
        public Statistics ShowStatistics()
        {
            var result = new Statistics();   
            foreach(var number in grades)
            {
                result.Add(number);                
            }
           
            return result;

        }

    }
}
