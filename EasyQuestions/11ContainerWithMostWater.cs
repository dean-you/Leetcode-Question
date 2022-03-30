using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _11ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            for (int i = 0; i < height.Length -1; i++)
            {
                for (int j = i+1; j < height.Length; j++)
                {
                    var area = Math.Min(height[i], height[j]) * (j - i);
                    max = Math.Max(max, area);
                }
            }
            return max;
        }

        public int MaxArea1(int[] height)
        {
            var max = 0;
            var left = 0;
            var right = height.Length - 1;
            var area = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                     area = height[left] * (right - left);
                     left++;
                }
                else
                {
                    area = height[right] * (right - left);
                    right--;
                }
                max = Math.Max(max, area);
            }
            return max;
        }
    }
}
