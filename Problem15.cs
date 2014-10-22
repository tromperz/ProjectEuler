using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem15
    {
        public string Lattice(int input1, int input2)
        {
            System.Numerics.BigInteger result = 0, dividend = 1, divisor1 = 1, divisor2 = 1;

            for (int i = 1; i <= (input1 + input2); i++)
            {
                dividend *= i;
            }
            for (int i = 1; i <= input1; i++)
            {
                divisor1 *= i;
            }
            for (int i = 1; i <= input2; i++)
            {
                divisor2 *= i;
            }

            result = dividend / (divisor1 * divisor2);

            return result.ToString();
        }
    }
}
