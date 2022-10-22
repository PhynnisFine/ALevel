using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amicable_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int max = 10000;
            int[] factorsum = new int[max + 1];

            for (int i = 2; i <= max; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if ((i % j) == 0)
                    {
                        factorsum[i] += j;
                    }
                    if (factorsum[i] > max)
                    {
                        factorsum[i] = 0;
                    }
                }

            }

            for (int i = 2; i <= max; i++)
            {
                if (factorsum[factorsum[i]] == i)
                {
                    Console.WriteLine(i + ", " + factorsum[i]);
                }
            }

            Console.ReadLine();

        }
    }
}
