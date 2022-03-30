using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _6ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            var sb = new StringBuilder();
            var setNum = 2 * numRows - 2;
            var setColNum = numRows - 1;
            var numCols = s.Length / setNum * setColNum + s.Length % setNum / numRows;
            if (s.Length % setNum > numRows)
                numCols += s.Length % setNum % numRows;
            else
            {
                numCols++;
            }
            var array = new char[numRows, numCols];
            var row = 0;
            var col = 0;
            var up = false;
            for (int i = 0; i < s.Length; i++)
            {
                array[row, col] = s[i];
                if (up)
                {
                    row--;
                    col++;
                }
                else
                    row++;
                if (row == numRows)
                {
                    up = true;
                    row = row - 2;
                    col++;
                }
                else if (row == -1)
                {
                    up = false;
                    row = row + 2;
                    col--;
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (array[i, j] != '\0')
                        sb.Append(array[i, j]);
                }
            }
            return sb.ToString();
        }
    }
}
