using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _40CombinationSum2
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<IList<int>> res = new List<IList<int>>();
            GetCombo(new List<int>(), target);
            return res;
            // local func
            bool GetCombo(List<int> curr, int t, int i = 0)
            {
                if (t < 0) return true;
                else if (t == 0)
                {
                    res.Add(new List<int>(curr));
                    return true;
                }
                else
                {
                    for (int idx = i; idx < candidates.Length; idx++)
                    {
                        if (idx > i && candidates[idx - 1] == candidates[idx])
                            continue;
                        curr.Add(candidates[idx]);
                        var breakloop = GetCombo(curr, t - candidates[idx], idx + 1);
                        curr.RemoveAt(curr.Count - 1);
                        if (breakloop)
                            break;
                        //while (idx < candidates.Length - 1 && candidates[idx + 1] == candidates[idx])
                        //{
                        //    idx++;
                        //}
                    }
                    return false;
                }
            }
        }
    }
}
