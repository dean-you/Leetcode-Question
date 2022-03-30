using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _119PascalTriangeII
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0) return new List<int>() { 1 };
            var prevRow = GetRow(rowIndex - 1);
            var curRow = new List<int>();
            curRow.Add(1);
            for (int j = 1; j < rowIndex; j++)
            {
                curRow.Add(prevRow[j - 1] + prevRow[j]);
            }
            curRow.Add(1);
            return curRow;
        }
    }
}
