using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem14
    {
        public long Collatz(int input)
        {
            long longest = 0, chain = 0, count = 0, a = 0;
            for (int i = 2; i < input; i++)
            {
                a = i;
                count = 0;
                while (a > 1)
                {
                    if(a % 2 == 0)
                    {
                        a /= 2;
                    }
                    else
                    {
                        a = (a * 3) + 1;
                    }
                    count++;
                }
                if(count > chain)
                {
                    chain = count;
                    longest = i;
                }
            }
            return longest;
        }
    }
}
