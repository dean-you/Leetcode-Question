using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _70ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;
            else
            {
                return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            }
        }
    }
}
