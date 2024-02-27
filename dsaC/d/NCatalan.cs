using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{
    public class NCatalan
    {

        private long[] factorialSeries;

        public NCatalan(int n)
        {
            factorialSeries = new long[2 * n + 1];

        }

        public long Factorial(int n)
        {
            if (n == 1)
            {
                factorialSeries[n] = 1;
                return 1;
            }

            factorialSeries[n] = n * Factorial(n - 1);
            return factorialSeries[n];


        }



        public void CatalanSeries(int n)
        {
            Factorial(2 * n);

            /*  for(int i=0;i<factorialSeries.Length;i++)
              {

                  Console.WriteLine(factorialSeries[i]);
              }*/


            for (int i = 1; i < n; i++)
            {
                long theNumber = factorialSeries[2 * i] / (factorialSeries[i + 1] * factorialSeries[i]);
                Console.WriteLine(theNumber);
            }

        }



    }
}
