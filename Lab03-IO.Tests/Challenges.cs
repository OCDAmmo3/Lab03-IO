using System;
using System.Collections.Generic;
using System.Text;
using Challenges;
using Xunit;

namespace Lab03_IO.Tests
{
    public class Challenges
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 1, 1, 0)]
        [InlineData(-1, 15, 1, -15)]
        public static void Challenge1_should_return_product_of_given_values(int val1, int val2, int val3, int result)
        {
            // Act
            int assert = Challenger.Challenge1(val1, val2, val3);

            // Assert
            Assert.Equal(result, assert);
        }
    }
}
