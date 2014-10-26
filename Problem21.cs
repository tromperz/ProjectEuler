using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem21
    {
        public int Amicable (int input)
        {
            int sum = 0, b = 0;
            for (int a = 2; a < input; a++)
            {
                b = Divisors(a);
                if(b > a)
                    if(Divisors(b) == a)
                        sum = sum + a + b;
            }
            return sum;
        }

        private int Divisors(int num)
        {
            int sum = -num;
            for (int i = 1; i <= Math.Floor(Math.Sqrt(num)); i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                    sum += (num / i);

                    if(i == (num / i))
                        sum -= i;
                }
            }
            return sum;
        }
    }
}
