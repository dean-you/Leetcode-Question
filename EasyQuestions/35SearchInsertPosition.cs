using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _35SearchInsertPosition
    { 
        public int SearchInsert(int[] nums, int target)
        {
            var start = 0 ;
            var end = nums.Length - 1;
            while (end > start)
            {
                var index = (end + start) / 2;
                if (nums[index] == target)
                    return index;
                if (nums[index] > target)
                {
                    end = index - 1;
                }
                else
                {
                    start = index + 1;
                }
            }

            if (nums[start] >= target)
                return start;
            else
                return start + 1;
        }
    }
}
