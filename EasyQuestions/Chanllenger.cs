using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EasyQuestions
{
    public class Chanllenger
    {

        public int Calculate()
        {
            int[] arr = { 4, 2, 3, 5, 2, 3, 1, 3 };
            var amount = 0;
            for (var i = 1; i < arr.Length - 1; i++)
            {
                amount += CalculateCurrent(i, arr);
            }
            return amount;
        }

        private int CalculateCurrent(int cur, int[] arr)
        {
            var maxLeft = arr[cur];
            var maxRight = arr[cur];
            for (var i = 0; i < cur; i++)
            {
                if (arr[i] > maxLeft)
                    maxLeft = arr[i];
            }

            for (var i = cur + 1; i < arr.Length; i++)
            {
                if (arr[i] > maxRight)
                    maxRight = arr[i];
            }

            if (maxLeft > arr[cur] && maxRight > arr[cur])
                return Math.Min(maxLeft, maxRight) - arr[cur];

            return 0;
        }
    }
}
