using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _704BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var mid = right / 2;
            while (left < mid && mid < right)
            {

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid;
                else
                    left = mid;
                mid = (left + right) / 2;
            }
            if (nums[left] == target)
                return left;
            if (nums[right] == target)
                return right;
            else return -1;
        }

        public int Search1(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }
    }
}
