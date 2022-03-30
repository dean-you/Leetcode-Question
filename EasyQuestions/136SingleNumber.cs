using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _136SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var list = new List<int>();
            foreach (var num in nums)
            {
                if (list.Contains(num))
                    list.Remove(num);
                else
                {
                    list.Add(num);
                }
            }
            return list[0];
        }
    }
}
