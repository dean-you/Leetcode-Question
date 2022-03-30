using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _26RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = nums.Length;
            for (int i = 0; i < k-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    k--;
                    for (int j = i; j < k; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    i--;
                }
            }
            return k;
        }

        public int RemoveDuplicates1(int[] nums)
        {
            var count = 0;

            foreach (var num in nums)
                if (nums[count] < num)
                {
                    count++;
                    nums[count] = num;
                }

            return nums.Length == 0 ? 0: count+1;
        }
    }
}
