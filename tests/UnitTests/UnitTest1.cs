using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CelsiusToFahrenheitTest()
        {
            var expected = 89.6;
            var a = 32.0;
            var actual = CelsiusToFahrenheit(a);
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(59,15.0)]
        [InlineData(33.8, 1.0)]
        [InlineData(14.0,-10.0)]
        public void CelsiusToFahrenheitTests(double exp, double n2)
        {
            Assert.Equal(exp, CelsiusToFahrenheit(n2));
        }
        double CelsiusToFahrenheit( double c)
        {
            return ((c * 9/5)+32);
            
        }

        [Fact]
        public void PerimeterTest()
        {
            var expected = 4.0;
            var a = 1.0;
            var actual = PerimeterOfSquare(a);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4.0, 1.0)]
        [InlineData(20.0, 5.0)]
        [InlineData(14.0, 3.5)]
        public void PerimeterTests(double exp, double n2)
        {
            Assert.Equal(exp, PerimeterOfSquare(n2));
        }
        
        double PerimeterOfSquare(double x)
        {
            return 4 * x;
        }
    }
}
