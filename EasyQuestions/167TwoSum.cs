using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _167TwoSum
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        result[0] = i + 1;
                        result[1] = j + 1;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
