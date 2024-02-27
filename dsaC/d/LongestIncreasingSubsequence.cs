using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{
    internal class LongestIncreasingSubsequence
    {
        /* Input: arr[] = {3, 10, 2, 1, 20}
         Output: 3
         Explanation: The longest increasing subsequence is 3, 10, 20

         Input: arr[] = {3, 2}
         Output:1
         Explanation: The longest increasing subsequences are {3}
          and {2}*/

        public Dictionary<string, int> Cache = new Dictionary<string, int>();
        public int Method(int[] arr, int i, int j)
        {

            if (i > j) return int.MinValue;

            if (i >= arr.Length || j >= arr.Length)
            {
                return 1;
            }
            string key = $"{i}-{j}";

            if (Cache.ContainsKey(key))
            {

                return Cache[key];
            }



            int max = int.MinValue;
            if (arr[j] > arr[i])
            {
                int val = 1 + Method(arr, j, j + 1);
                max = Math.Max(max, val);
            }
            int val2 = Math.Max(Method(arr, i, j + 1), Method(arr, i + 1, j));

            Cache[key] = Math.Max(max, val2);
            return Cache[key];



        }


    }
}
