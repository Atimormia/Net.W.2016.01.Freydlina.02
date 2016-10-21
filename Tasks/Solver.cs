using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Solver
    {
        static public int Task1(int[] arr)
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

        static public string LongestTask2(string a, string b)
        {
            string str = a + b;
            SortedSet<char> charSet = new SortedSet<char>();
            for (int i = 0; i < str.Length; i++)
            {
                charSet.Add(str[i]);
            }
            return new string(charSet.ToArray());
        }

        static public int InsertionTask3(int a, int b, int i, int j)
        {

        }
    }
}
