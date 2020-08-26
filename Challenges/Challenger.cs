using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class Challenger
    {
        public static int Challenge1(int[] values)
        {
            if (values.Length < 3)
            {
                return 0;
            }
            try
            {
                return Multiply(values[0], Multiply(values[1], values[2]));
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                throw;
            }
        }

        public static int Multiply(int val1, int val2)
        {
            return val1 * val2;
        }

        public static int Challenge2(int number)
        {
            return 0;
        }
    }
}
