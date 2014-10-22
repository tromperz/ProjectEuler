using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem9
    {
        public int Triplet(int input)
        {
            int a = 1, b = 1, c = 1;

            for(a = 1; a < input-2; a++)
            {
                b = 1;
                for(b = (a + 1); b < (input-a); b++)
                {
                    c = input - a - b;
                    if((c*c) == ((a*a) + (b*b)))
                    {
                        return (a * b * c);
                    }
                }
            }
            return -1;
        }
    }
}
