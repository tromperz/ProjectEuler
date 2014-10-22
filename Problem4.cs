using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem4
    {
        public int Product(int input)
        {
            int i = 0, j = 0, largest = 0;
            while (i<input)
            {
                j = 0;
                while (j<input)
                {
                    if(Palindrome(i*j))
                    {
                        if (i * j > largest)
                            largest = i * j;
                    }
                    j++;
                }
                i++;
            }
            return largest;
        }

        bool Palindrome(int number)
        {
            return number.ToString().SequenceEqual(number.ToString().Reverse());
        }
    }
}
