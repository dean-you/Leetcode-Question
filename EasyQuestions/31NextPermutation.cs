using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _31NextPermutation
    {
        public int[] NextPermutation(int[] nums)
        {
            for (int i = nums.Length -2; i >= 0; i--)
            {
                var temp = 0;
                for (int j = i+1; j < nums.Length; j++)
                {
                    //swap the number and return the array
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        return nums;
                    }
                }
                //If reach here, it means the current num[i] is bigger than any number after index i and we need to sort the num from index i to the end.
                temp = nums[i];
                for (int j = i+1; j < nums.Length ; j++)
                {
                    nums[j-1] = nums[j];
                }
                nums[nums.Length - 1] = temp;
            }
            return nums;
        }
    }
}
