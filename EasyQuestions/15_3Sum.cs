using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _15_3Sum
    {
        public IList<IList<int>> ThreeSum_Wrong(int[] nums)
        {
            var result = new List<IList<int>>();
            for (int i = 0; i < nums.Length-2; i++)
            {
                for (int j = i+1; j < nums.Length-1; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var item = new List<int>() {nums[i], nums[j], nums[k]};
                            item.Sort();
                            if (!result.Contains(item))
                                result.Add(item);
                        }
                    }
                }
            }
            return result;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            // Sort the array
            Array.Sort(nums);

            // Loop through numbers
            for (int index = 0; index < nums.Length; ++index)
            {
                // Skip duplicates
                if (index != 0 && nums[index] == nums[index - 1])
                {
                    continue;
                }

                // Get the target search value, which is the additive inverse of the current number
                var target = 0 - nums[index];

                // Find all 2 sum combinations that equal the target value
                var startIndex = index + 1;
                var endIndex = nums.Length - 1;
                while (startIndex < endIndex)
                {
                    // Get the sum
                    var sum = nums[startIndex] + nums[endIndex];

                    // Sum equals target
                    if (sum == target)
                    {
                        // Add values to results when a target is found
                        var value1 = nums[startIndex];
                        var value2 = nums[endIndex];
                        result.Add(new List<int> { nums[index], value1, value2 });

                        // Advance past duplicate items to the 'next' values 
                        // at the start and of the array
                        while (startIndex < endIndex && value1 == nums[startIndex])
                        {
                            ++startIndex;
                        }
                        while (startIndex < endIndex && value2 == nums[endIndex - 1])
                        {
                            --endIndex;
                        }

                        // Sum is less than target
                    }
                    else if (sum < target)
                    {
                        ++startIndex;

                        // Sum is greater than target
                    }
                    else
                    {
                        --endIndex;
                    }
                }
            }

            return result;
        }
    }
}
