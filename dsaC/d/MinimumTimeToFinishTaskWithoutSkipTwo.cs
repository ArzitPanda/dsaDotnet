using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{

    /*Given the time taken by n tasks.Find the minimum time needed to finish the tasks such that skipping of tasks is allowed, but can not skip two consecutive tasks.

    Examples : 

    Input : arr[] = {10, 5, 7, 10}
    Output: 12
    We can skip first and last task and
    finish these task in 12 min.

    Input : arr[] = { 10 }
    Output : 0
    There is only one task and we can
    skip it.

    Input : arr[] = { 10, 30 }
    Output : 10

    Input: arr[] = { 10, 5, 2, 4, 8, 6, 7, 10 }
    Output: 22

*/


    internal class MinimumTimeToFinishTaskWithoutSkipTwo
    {

        public Dictionary<string, int> CACHE = new Dictionary<string, int>();
        public int Method(int[] arr, int idx, bool Canskip)
        {
            if (idx >= arr.Length)
            {
                return 0;
            }


            string Key = $"{Canskip} - {idx}";
            if (CACHE.ContainsKey(Key))
            {
                return CACHE[Key];
            }



            int skip = 0;
            //i will skip
            if (Canskip)
            {
                skip = Method(arr, idx + 1, !Canskip);
            }
            else
            {
                skip = arr[idx] + Method(arr, idx + 1, true);
            }

            int NotSkip = arr[idx] + Method(arr, idx + 1, true);

            CACHE[Key] = Math.Min(skip, NotSkip);

            return CACHE[Key];


        }


        public int Helper(int[] arr, int idx)
        {

            return Math.Min(Method(arr, idx, false), Method(arr, idx, true));


        }



    }
}
