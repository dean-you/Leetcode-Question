using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _567PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var result = false;
            var list = s1.ToList();
            var start = 0;
            var end = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                if (list.Contains(s2[i]))
                {
                    list.Remove(s2[i]);
                    if (list.Count == 0)
                        return true;
                }
                else
                {
                    if (s1.IndexOf(s2[i]) > 0)
                    {
                        var str = s2.Substring(start, i - start+1);
                        var index = str.IndexOf(s2[i]);
                        if (index > 0)
                        {
                            list.AddRange(s2.Substring(0, index));
                            start += index + 1;
                        }
                        else
                        {
                            start++;
                        }
                    }
                    else
                    {
                        list = s1.ToList();
                        start = i + 1;
                    }
                }
            }
            return result;
        }

        public bool checkInclusion1(String s1, String s2)
        {
            if (s1.Length > s2.Length)
                return false;
            int[] s1map = new int[26];
            int[] s2map = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                s1map[s1[i] - 'a']++;
                s2map[s2[i] - 'a']++;
            }

            int count = 0;
            for (int i = 0; i < 26; i++)
                if (s1map[i] == s2map[i])
                    count++;

            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                if (count == 26)
                    return true;
                int r = s2[i + s1.Length] - 'a';
                int l = s2[i] - 'a';
                s2map[r]++;
                if (s2map[r] == s1map[r])
                    count++;
                else if (s2map[r] == s1map[r] + 1)
                    count--;
                s2map[l]--;
                if (s2map[l] == s1map[l])
                    count++;
                else if (s2map[l] == s1map[l] - 1)
                    count--;
            }
            return count == 26;
        }
    }
}
