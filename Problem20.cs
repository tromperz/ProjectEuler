using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem20
    {
        public int Factorial(int input)
        {
            System.Numerics.BigInteger result = 1;
            int sum = 0;

            for(int i = 1; i <= input; i++)
            {
                result *= i;
            }

            foreach(char c in result.ToString())
            {
                sum += Int32.Parse(c.ToString());
            }
            return sum;
        }
    }
}
