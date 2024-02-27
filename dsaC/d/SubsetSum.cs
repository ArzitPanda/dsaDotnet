using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{

    /*  Input: set[] = {3, 34, 4, 12, 5, 2}, sum = 9
Output: True
Explanation: There is a subset(4, 5) with sum 9.

Input: set[] = {3, 34, 4, 12, 5, 2}, sum = 30
Output: False
Explanation: There is no subset that add up to 30.*/
    internal class SubsetSum
    {
        HashSet<string> subsets = new HashSet<string>();
        public bool Method(int[] arr, int sum, int i)
        {
            if (i >= arr.Length) return false;

            if (sum < 0) return false;

            if (sum == 0) return true;

            string keys = $"{sum}-{i}";

            if (subsets.Contains(keys)) return true;




            bool val = Method(arr, sum - arr[i], i + 1) || Method(arr, sum, i + 1);
            if (val == true)
            {
                subsets.Add(keys);
            }


            return val;




        }


    }
}
