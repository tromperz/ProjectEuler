using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem1
    {
        public int Multiple(int input)
        {
            int output = 0;
            for (int i = 3; i < input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    output += i;
            }
            return output;
        }
    }
}
