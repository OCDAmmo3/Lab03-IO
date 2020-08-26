using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class Challenger
    {
        public static int Challenge1(int val1, int val2, int val3)
        {
            try
            {
                return val1 * val2 * val3;
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                throw;
            }
        }
    }
}
