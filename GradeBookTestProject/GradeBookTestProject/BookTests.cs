using System;
using Xunit;

namespace GradeBookTestProject
{
    public class BookTests 
    {
        [Fact]
        public void Test1()
        {
            var x= 5;
            var y= 2;
            var expected = 7;
            //var expected = 10;
            var actual = x * y;

            Assert.NotEqual(expected, actual);

        }
    }
}
