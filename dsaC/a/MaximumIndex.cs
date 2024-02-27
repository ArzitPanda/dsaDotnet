using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.a
{

   /* Given an array arr[] of N positive integers.The task is to find the maximum of j – i subjected to the constraint of arr[i] <= arr[j].

    Examples : 

      Input: { 34, 8, 10, 3, 2, 80, 30, 33, 1}
        Output: 6  (j = 7, i = 1)

      Input: {9, 2, 3, 4, 5, 6, 7, 8, 18, 0}
    Output: 8(j = 8, i = 0)

      Input: { 1, 2, 3, 4, 5, 6}
    Output: 5(j = 5, i = 0)

      Input: { 6, 5, 4, 3, 2, 1}
    Output: 0*/
   public  class MaximumIndex
    {
          
        
        int Method(int[] arr )
        {


            int max = int.MinValue;

            for(int i=0;i<arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        max = Math.Max(j-i, max);
                    }
                }


            }
            return max;

        }



    }
}
