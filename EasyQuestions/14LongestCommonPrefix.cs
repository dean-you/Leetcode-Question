using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _14LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length)
                        return result;
                    if (strs[0][i] != strs[j][i])
                        return result;
                }
                result += strs[0][i];
            }
            return result;
        }
    }
}
