using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _41FirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);
            //Try to find the position of number 1
            int left = 0;
            int right = nums.Length - 1;
            var mid = 0;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (nums[mid] == 1)
                    break;
                else if (nums[mid] > 1)
                    right--;
                else
                    left++;
            }
            if (left <= right)
            {
                var index = mid + 1;
                while (index < nums.Length)
                {
                    if (nums[index] == nums[index - 1] + 1 || nums[index] == nums[index - 1])
                        index++;
                    else
                        break;
                }
                return nums[index - 1] + 1;
            }
            else
                return 1;
        }
    }
}
