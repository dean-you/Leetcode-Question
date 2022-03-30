using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _189RotateArray
    {
        public int[] Rotate(int[] nums, int k)
        {
            int[] numCopy = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numCopy[i] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var index = (i + nums.Length - (k % nums.Length)) % nums.Length;
                nums[i] = numCopy[index];
            }
            return nums;
        }

        public int[] Rotate1(int[] nums, int k)
        {
            int length = nums.Length;
            k %= length;
            if (k == 0)
                return nums;

            int count = 0;
            for (int i = 0; count < length; i++)
            {
                int curInd = i;
                int prev = nums[i];
                do
                {
                    int nextInd = (curInd + k) % length;
                    int temp = nums[nextInd];
                    nums[nextInd] = prev;
                    curInd = nextInd;
                    prev = temp;
                    count++;
                } while (curInd != i);
            }
            return nums;
        }
    }
}
