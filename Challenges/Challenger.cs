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

        public static int Challenge2(int value, int[] array)
        {
            if (value < 2)
                value = 2;
            if (value > 10)
                value = 10;

            int[] result = new int[value];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[i];
                if (array[i] == 0)
                    return 0;
            }

            return Averager(result);
        }

        public static int Averager(int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum / values.Length;
        }

        public static void Challenge3()
        {
            for (int i = 0; i < 5; i++)
            {
                string[] spaces = new string[4 - i];
                Array.Fill(spaces, " ");
                string space = String.Join("", spaces);
                string[] stars = new string[i];
                Array.Fill(stars, "*");
                string star = String.Join("", stars);
                string final = $"{space}{star}*{star}{space}";
                Console.WriteLine(final);
            }
            for (int i = 3; i >= 0; i--)
            {
                string[] spaces = new string[4 - i];
                Array.Fill(spaces, " ");
                string space = String.Join("", spaces);
                string[] stars = new string[i];
                Array.Fill(stars, "*");
                string star = String.Join("", stars);
                string final = $"{space}{star}*{star}{space}";
                Console.WriteLine(final);
            }
        }

        public static int Challenge4(int[] values)
        {
            Array.Sort(values);

            int mostPop = 1;
            int result = values[0];
            int curr = 1;

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == values[i - 1])
                    curr++;
                else
                {
                    if (curr > mostPop)
                    {
                        mostPop = curr;
                        result = values[i - 1];
                    }
                    curr = 1;
                }
            }
            return result;
        }
    }
}
/*

    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    * 
    
 */