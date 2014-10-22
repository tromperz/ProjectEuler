using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem10
    {
        public long Summation(int input)
        {
            long output = 5;
            for (int i = 5; i < input; i+=2)
            {
                if(prime(i))
                {
                    output += i;
                }
            }
            return output;
        }

        bool prime(int number)
        {
            if (number == 1) return false;
            else if (number < 4) return true;
            else if (number % 2 == 0) return false;
            else if (number < 9) return true;
            else if (number % 3 == 0) return false;
            else
            {
                for (int i = 5; i <= Math.Floor(Math.Sqrt(number)); i+=6)
                {
                    if (number % i == 0) return false;
                    if (number % (i + 2) == 0) return false;
                }
            }
            return true;
        }
    }
}
