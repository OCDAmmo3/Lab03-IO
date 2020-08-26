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
            // Arrange
            int[] values = new int[1] { 2 };

            // Act
            int result = Challenger.Challenge1(values);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public static void Challenge1_should_return_product_of_first_3_digits_given_more_than_3()
        {
            // Arrange
            int[] values = new int[5] { 1, 2, 3, 4, 5 };

            // Act
            int result = Challenger.Challenge1(values);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public static void Averager_should_return_average_of_4_numbers_in_length_4_array_rounded_down()
        {
            // Arrange
            int[] values = new int[4] { 10, 13, 12, 4 };

            // Act
            int result = Challenger.Averager(values);

            // Assert
            Assert.Equal(9, result);
        }

        [Fact]
        public static void Challenge2_should_make_an_array_with_given_values_then_run_Averager_and_return_average_value()
        {
            // Arrange
            const int value = 5;
            int[] values = new int[value] { 1, 2, 3, 4, 5 };

            // Act
            int result = Challenger.Challenge2(value, values);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public static void Challenge2_returns_0_for_an_array_with_0_in_it()
        {
            // Arrange
            const int value = 4;
            int[] values = new int[value] { 0, 0, 0, 0 };

            // Act
            int result = Challenger.Challenge2(value, values);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public static void Challenge4_returns_most_common_value_in_array()
        {
            // Arrange
            int[] values = new int[10] { 1, 1, 1, 2, 3, 2, 5, 6, 3, 10 };

            // Act
            int result = Challenger.Challenge4(values);

            // Assert
            Assert.Equal(1, result);
        }
    }
}