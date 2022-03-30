using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _42TrappingRainWater
    {
        public int Trap(int[] height)
        {
            var res = 0;
            for (int i = 1; i < height.Length - 1; i++)
            {
                var maxLeft = 0;
                for (int j = 0; j < i; j++)
                {
                    if (height[j] > maxLeft)
                        maxLeft = height[j];
                }
                var maxRight = 0;
                for (int j = i+1; j < height.Length; j++)
                {
                    if (height[j] > maxRight)
                        maxRight = height[j];
                }
                var min = Math.Min(maxLeft, maxRight);
                if (height[i] < min)
                    res += min - height[i];
            }
            return res;
        }

        public int Trap_Stack(int[] height)
        {
            Stack<int> st = new Stack<int>(height.Length);
            int waterCollected = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int lastHeight = 0;
                // Calculate possible water that got collection by comparing current elevation
                // with ones present in stack
                while (st.Count > 0)
                {
                    var top = st.Peek();
                    var lengthOfBucket = i - top - 1;
                    if (lengthOfBucket > 0)
                        waterCollected += lengthOfBucket * (Math.Min(height[i], height[top]) - lastHeight);
                    lastHeight = height[top];

                    // if last elevation was smaller we have already calculated water b/w it and current hence pop
                    if (lastHeight <= height[i]) st.Pop();
                    // process stop when hit last elevation which is bigger than current
                    else break;
                }
                // Insert new elevation index from heights array
                st.Push(i);
            }
            return waterCollected;
        }

        public int Trap_TwoPointers(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var res = 0;
            var leftMax = 0;
            var rightMax = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        res += leftMax - height[left];
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        res += rightMax - height[right];
                    right--;
                }
            }
            return res;
        }
    }
}
