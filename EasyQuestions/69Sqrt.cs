using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _69Sqrt
    {
        public int MySqrt(int x)
        {
            if (x==1)
                return 1;
            int big = x;
            int small = 0;

            while (big - small > 1)
            {
                long m = (big + small) / 2;
                if (m * m == x)
                    return (int)m;
                if (m * m > x)
                    big = (int)m;
                else
                    small = (int)m;
            }
            return small;
        }
    }
}
