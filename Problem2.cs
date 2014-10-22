using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem2
    {
        public int Fibonacci(int input)
        {
            int output = 0, i = 1, j = 2, k = 0;
            while(k<input)
            {
                if (j % 2 == 0)
                {
                    output += j;
                }

                k = i + j;
                i = j;
                j = k;
            }
            return output;
        }
    }
}
