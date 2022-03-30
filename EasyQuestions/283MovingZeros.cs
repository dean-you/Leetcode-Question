using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _283MovingZeros
    {
        public void MoveZeroes(int[] nums)
        {
            var len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < len; j++)
                    {
                        if (j == len - 1)
                            nums[j] = 0;
                        else
                            nums[j] = nums[j + 1];
                    }
                    len--;
                    i--;
                }
            }
        }

        public void MoveZeroes1(int[] nums)
        {
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
