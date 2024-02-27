using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{
    /*  Input: arr[] = {1, 2, 3, 4, 5, 6, 7, 8}
  Output: 6
  6 is sum of output subsequence {1, 5}
  Note that we have following subarrays of four
  consecutive elements
  {(1, 2, 3, 4),
   (2, 3, 4, 5),
   (3, 4, 5, 6)
   (4, 5, 6, 7)
   (5, 6, 7, 8)}
  Our subsequence {1, 5}
  has an element from
  all above groups of four consecutive elements.
  And this subsequence is minimum sum suchdada
  subsequence.
  Input : arr[] = { 1, 2, 3, 3, 4, 5, 6, 1 }
  Output : 4
  The subsequence is {3, 1}. Here we consider
  second three.
  Input: arr[] = { 1, 2, 3, 2, 1 }
  Output: 2
  The subsequence can be {1, 1} or {2}
  Input: arr[] = { 6, 7, 8 }
  Output: 6
  Input: arr[] = { 6, 7 }
  Output: 6*/

    internal class MinimumSubSequenceFourConsecutive
    {
        public void Method(int[] arr)
        {
            for (int i = 0; i < arr.Length - 3; i++)
            {
                for (int j = i; j < i + 4; j++)
                {
                    Console.Write(arr[j]);
                }
                Console.WriteLine();


            }

        }


    }
}
