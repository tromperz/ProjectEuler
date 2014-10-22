using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem7
    {
        public int Prime(int input)
        {
            int output = 0;
            while(input > 0)
            {
                output++;
                if(prime(output))
                    input--;
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
                for (int i = 5; i <= Math.Floor(Math.Sqrt(number)); i += 6)
                {
                    if (number % i == 0) return false;
                    if (number % (i + 2) == 0) return false;
                }
            }
            return true;
        }
    }
}
