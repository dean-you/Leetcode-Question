using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _33SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                if (nums[start] == target)
                    return start;
                else if (nums[end] == target)
                    return end;
                var middle = (end + start) / 2;
                if (nums[middle] == target)
                    return middle;
                if (nums[start] < nums[middle])
                {
                    if (nums[start] < target && target < nums[middle])
                        end = middle - 1;
                    else
                        start = middle + 1;
                }
                else
                {
                    if (nums[middle] < target && target < nums[end])
                        start = middle + 1;
                    else
                        end = middle - 1;
                }                
            }
            return -1;
        }
    }
}
