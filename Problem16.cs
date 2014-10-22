using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem16
    {
        public int PowerInt(int input)
        {
            int sum = 0;
            System.Numerics.BigInteger result = (System.Numerics.BigInteger)(Math.Pow(2, input));
            string strResult = result.ToString();
            
            foreach(char c in strResult)
            {
                sum += Convert.ToInt32(Convert.ToString(c));
            }
            return sum;
        }
    }
}
