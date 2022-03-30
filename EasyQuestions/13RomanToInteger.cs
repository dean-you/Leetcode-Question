using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _13RomanToInteger
    {
        enum RomanToIntegerMap
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public int RomanToInt(string s)
        {
            var preNum = int.MaxValue;
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var curNum = Map(s[i]);
                if (curNum > preNum)
                    result = result + curNum - preNum * 2;
                else
                {
                    result = result + curNum;
                    preNum = curNum;
                }
            }
            return result;
        }

        private static int Map(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    throw new Exception("Invalid Roman Char");
            }
        }
    }
}
