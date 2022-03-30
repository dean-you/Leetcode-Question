using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _34FindFirstAndLastPositionOfElementsInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    var leftMost = searchLeft(nums, left, mid, target);
                    var rightMost = searchRight(nums, mid, right, target);   
                    return new int[2] { leftMost, rightMost };
                }
                if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return new int[2] { -1, -1 };
        }

        private int searchRight(int[] nums, int left, int right, int target)
        {
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return right;

        }

        private int searchLeft(int[] nums, int left, int right, int target)
        {
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return left;
        }

    }
}
