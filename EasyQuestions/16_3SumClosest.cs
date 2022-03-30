using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _16_3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            var result = 3001;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var newTarget = target - nums[i];
                var left = i+1;
                var right = nums.Length - 1; 
                var sum = nums[left] + nums[right];
                while (left < right)
                {
                    sum = nums[left] + nums[right];
                    if (sum == newTarget)
                        return target;
                    if (sum > newTarget)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                    var resultDiff = Math.Abs(result - target);
                    var sumDiff = Math.Abs(sum - newTarget);
                    if (resultDiff > sumDiff)
                        result = sum + nums[i];
                }
            }
            return result;
        }
    }
}
