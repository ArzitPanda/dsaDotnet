using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{
    /*  Given a rope of length n meters, cut the rope in different parts of integer lengths in a way that 
     *  maximizes product of lengths of all parts.You must make at least one cut.
     *  Assume that the length of rope is more than 2 meters*/
    internal class MaximumProductCutting
    {
        public Dictionary<string, int> cache = new Dictionary<string, int>();
        public int method(int a, int i)
        {



            if (a == 0)
            {
                return 1;
            }
            if (i > a) return 0;


            string key = $"{a}-{i}";

            if (cache.ContainsKey(key))
            {

                return cache[key];

            }

            //first cut with i 
            int length = i * method(a - i, i);

            //then ignore i 
            int anotherlength = method(a, i + 1);

            cache[key] = Math.Max(length, anotherlength);
            return cache[key];



        }



    }
}
