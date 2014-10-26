using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem23
    {
        public int NonAbundantSum()
        {
            int sum = 0;
            HashSet<int> abundants = new HashSet<int>();
            HashSet<int> sumAbundants = new HashSet<int>();

            for (int i = 12; i < 28123; i++)
                if (isAbundant(i)) 
                    abundants.Add(i);

            foreach (int a in abundants)
                foreach (int b in abundants)
                    sumAbundants.Add(a + b);

            for (int i = 1; i <= 28123; i++)
                if (!sumAbundants.Contains(i))
                    sum += i;

            return sum;
        }

        private bool isAbundant(int num)
        {
            int sum = -num;
            for (int i = 1; i <= Math.Floor(Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    sum += (num / i);

                    if (i == (num / i))
                        sum -= i;
                }
            }
            return sum > num;
        }
    }
}
