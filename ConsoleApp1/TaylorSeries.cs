using System;

namespace ConsoleApp1
{
    public class TaylorSeries
    {
        public double CalculateExp(double x, int k)
        {
            double exp = 0;
            
            for (int n = 0; n <= k; n++)
            {
                exp += Math.Pow(x, n) / Fact(n);
            }

            return exp;
        }

        static int Fact(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }
    }
}
