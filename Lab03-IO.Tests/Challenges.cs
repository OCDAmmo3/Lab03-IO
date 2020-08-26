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
        [InlineData(new[] { 1, 2, 3 }, 6)]
        [InlineData(new[] { 0, 1, 1 }, 0)]
        [InlineData(new[] { -1, 15, 1 }, -15)]
        public static void Challenge1_should_return_product_of_given_values(int[] values, int result)
        {
            // Act
            int assert = Challenger.Challenge1(values);

            // Assert
            Assert.Equal(result, assert);
        }

        [Fact]
        public static void Challenge1_should_return_0_given_less_than_3_numbers()
        {
            // Assert
            int[] values = new int[1] { 2 };

            // Act
            int result = Challenger.Challenge1(values);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public static void Challenge1_should_return_product_of_first_3_digits_given_more_than_3()
        {
            // Assert
            int[] values = new int[5] { 1, 2, 3, 4, 5 };

            // Act
            int result = Challenger.Challenge1(values);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
