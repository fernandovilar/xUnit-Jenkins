using System;
using Xunit;
using SimpleMathLib;

namespace SimpleMathTest
{
    public class MathTest
    {        
        
        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(5, 5.5, 10.5)]
        [InlineData(-5, 5.5, 0.5)]
        public void SumTest(double a, double b, double expected)
        {
            var m = new SimpleMathLib.Math();
            var result = m.Sum(a, b);
            Assert.Equal(expected, result);
        }
    }
}