using System;
using System.Collections.Generic;
using System.Text;

namespace Module4_GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count ;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                //Pattern matching with Switch
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                        
                    case var d when d >= 75.0:
                        return 'B';
                        
                    case var d when d >= 55.0:
                        return 'C';
                        
                    case var d when d >= 40.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double Sum;
        public int Count;

        public Statistics()
        {
           // Average = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = 0.0;
            Count = 0;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

    }
}
