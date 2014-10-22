using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem6
    {
        public int Difference(int input)
        {
            double Sum1 = 0, Sum2 = 0;
            for (int i = 1; i <= input; i++)
            {
                Sum1 += Math.Pow(i, 2);
                Sum2 += i;
            }
            Sum2 = Math.Pow(Sum2, 2);
            return (int)(Sum2 - Sum1);
        }
    }
}
