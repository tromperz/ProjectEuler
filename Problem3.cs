using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem3
    {
        public int Factor(long input)
        {
            int output = 0;
            while (output < input)
            {
                output++;
                if (prime(output))
                {
                    if (input % output == 0)
                        input /= output;
                }
            }
            return output;
        }

        bool prime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
