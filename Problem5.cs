using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem5
    {
        public double Divisible(int input)
        {
            int i = 0;
            double output = 1, limit = 0;
            bool check = true;
            List<double> p = new List<double>();
            double[] e = new double[20];

            while (i < (input*2))
            {
                if(prime(i))
                {
                    p.Add(i);
                }
                i++;
            }

            i = 0;
            limit = Math.Sqrt(input);

            while(p[i] <= input)
            {
                e[i] = 1;
                if (check)
                {
                    if(p[i] <= limit)
                    {
                        e[i] = Math.Floor(Math.Log(input) / Math.Log(p[i]));
                    }
                    else
                    {
                        check = false;
                    }
                }
                output *= Math.Pow(p[i], e[i]);
                i++;
            }

            return output;
        }
        bool prime(double number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
