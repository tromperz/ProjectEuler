using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem12
    {
        public long Divisors(int input)
        {
            long triangle = 1, x = 1;
            double limit = 1;
            int count = 0;
            while (count <= input)
            {
                count = 0;
                x++;
                triangle += x;
                limit = Math.Sqrt(triangle);

                for(int i = 1; i <= limit; i++)
                {
                    if(triangle % i == 0)
                        count += 2;
                }

                if (triangle == limit * limit)
                    count--;
            }
            return triangle;
        }
    }
}
