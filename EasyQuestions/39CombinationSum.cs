using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _39CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
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
                        curr.Add(candidates[idx]);
                        var breakloop = GetCombo(curr, t - candidates[idx], idx);
                        curr.RemoveAt(curr.Count - 1);
                        if (breakloop)
                            break;
                    }
                    return false;
                }
            }
        }
    }
}
