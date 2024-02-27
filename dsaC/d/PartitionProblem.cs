using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{

/*    The partition problem is to determine whether a given set can be partitioned into two subsets such that the sum of elements in both subsets is the same.

    Examples: 

    Input: arr[] = { 1, 5, 11, 5}
        Output: true 
    The array can be partitioned as {1, 5, 5}
    and {11}

    Input: arr[] = { 1, 5, 3 }
    Output: false
    The array cannot be partitioned into equal sum sets.*/


    internal class PartitionProblem
    {



        

        public int ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;


        }



        public HashSet<string> Cache = new HashSet<string>();

        public bool Helper(int[] arr,int i,int sum,int totalSum)
        {
            if(i>=arr.Length) { return false; }


            if(sum > (totalSum / 2)) return false;

            string Key = $"{i}-{sum}";
            
            if(Cache.Contains(Key))
            {
                return true;
            }



            if(sum==(totalSum/2))
            {
                return true;
            }
           

           if(Helper(arr, i + 1, sum + arr[i],totalSum) || Helper(arr,i+1,sum,totalSum))
            {
                Cache.Add(Key);
                return true;
            }
           else
            {
                return false;
            }

        }


        public bool Method(int[] arr)
        {
            int totalsum = ArraySum(arr);

            bool value = Helper(arr, 0, 0, totalsum);

            return value;
        }

    }
}
