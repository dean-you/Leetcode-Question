using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    internal class _36ValidSudoku
    {
        private const char DOT = '.';

        public bool IsValidSudoku(char[][] board)
        {
            if (!ValidRows(board))
                return false;

            if (!ValidColumns(board))
                return false;

            if (!ValidSubbox(board))
                return false;

            return true;

        }

        private bool ValidSubbox(char[][] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var hash = new HashSet<char>();
                    for (int k = i * 3; k < (i + 1) * 3; k++)
                    {
                        for (int l = j * 3; l < (j + 1) * 3; l++)
                        {
                            var cur = board[k][l];
                            if (cur == DOT)
                                continue;
                            if (hash.Contains(cur))
                                return false;
                            else
                                hash.Add(cur);
                        }
                    }
                }
            }
            return true;
        }

        private bool ValidColumns(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                var hash = new HashSet<char>();
                for (int j = 0; j < board.Length; j++)
                {
                    var cur = board[j][i];
                    if (cur == DOT)
                        continue;
                    if (hash.Contains(cur))
                        return false;
                    else
                        hash.Add(cur);
                }
            }
            return true;
        }

        private bool ValidRows(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                var hash = new HashSet<char>();
                for (int j = 0; j < board.Length; j++)
                {
                    var cur = board[i][j];
                    if (cur == DOT)
                        continue;
                    if (hash.Contains(cur))
                        return false;
                    else
                        hash.Add(cur);
                }
            }
            return true;
        }
    }
}
