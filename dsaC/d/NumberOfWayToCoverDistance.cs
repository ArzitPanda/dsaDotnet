using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.d
{

    //Given a distance ‘dist’, count total number of ways to cover the distance with 1, 2 and 3 steps.
    internal class NumberOfWayToCoverDistance
    {


        public Dictionary<int, int> cache = new Dictionary<int, int>();
        public int Method(int n)
        {



            if (n < 0)
            {
                Console.Write("Not Valid");
                Console.WriteLine();
                return 0;
            }



            if (n == 0)
            {
                Console.Write("completed");
                Console.WriteLine();
                return 1;
            }

            if (cache.ContainsKey(n)) return cache[n];


            //only  by one

            int firrst = Method(n - 1);

            int second = Method(n - 2);

            int third = Method(n - 3);

            int sum = firrst + second + third;

            cache[n] = sum;

            return sum;





        }


    }
}
