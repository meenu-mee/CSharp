using Module4_GradeBook;
using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            /*var x = 5;
            var y = 2;
            var expected = 7;
            //var expected = 10;
            var actual = x * y;

            Assert.Equal(expected, actual);*/

            var book = new Book("");
            book.AddGrade(76.1);
            book.AddGrade(87.1);
            book.AddGrade(93.9);

            var result = book.ShowStatistics(); //returns Statistics object

            Assert.Equal(85.2, result.Average, 1);//1 used for precision of decimal place used in comparison (85.6 = 85.63333)
            Assert.Equal(93.9, result.High);
            Assert.Equal(76.1, result.Low);

        }
    }
}
