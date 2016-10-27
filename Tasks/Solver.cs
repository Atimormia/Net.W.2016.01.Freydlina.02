using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    /// <summary>
    /// Represents solving problems
    /// </summary>
    public class Solver
    {
        /// <summary>
        /// Finds index that devides array on left and right part which sums is equal
        /// </summary>
        /// <param name="arr">Array</param>
        /// <returns>Index</returns>
        public static int Task1(int[] arr)
        {
            int sumLeft = 0;
            int sumRight = arr.Sum()-arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sumLeft += arr[i - 1];
                sumRight -= arr[i];

                if (sumLeft == sumRight)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Generates string of unique characters from strings a and b
        /// </summary>
        /// <param name="a">String a</param>
        /// <param name="b">String b</param>
        /// <returns>String of unique characters</returns>
        public static string LongestTask2(string a, string b)
        {
            string str = a + b;
            SortedSet<char> charSet = new SortedSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                charSet.Add(str[i]);
            }
            return new string(charSet.ToArray());
        }

        /// <summary>
        /// Insert number b in number a from i bit to j bit
        /// </summary>
        /// <param name="a">Number a</param>
        /// <param name="b">Number b</param>
        /// <param name="i">Bit index i</param>
        /// <param name="j">Bit index j</param>
        /// <returns>New number</returns>
        public static int InsertionTask3(int a, int b, int i, int j)
        {
            BynaryNumber bynary1 = new BynaryNumber(a);
            BynaryNumber bynary2 = new BynaryNumber(b);
            return bynary1.Insertion(bynary2, i, j);
        }
    }
}
