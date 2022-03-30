using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _542Matrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            var r = new int[mat.Length][];
            for (int i = 0; i < mat.Length; i++)
            {
                r[i] = new int[mat[i].Length];
                for (int j = 0; j < mat[i].Length; j++)
                {
                    r[i][j] = int.MinValue;
                }
            }
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    r[i][j] = Helper(mat, i, j, r);
                }
            }
            return r;
        }

        private int Helper(int[][] mat, int i, int j, int[][] r)
        {
            if (i < 0 || i >= mat.Length || j < 0 || j >= mat[0].Length)
                return int.MaxValue;
            if (mat[i][j] == 0)
                return 0;
            else
            {
                var top = r[i - 1][j] != int.MinValue ? r[i - 1][j] + 1 : Helper(mat, i - 1, j, r) + 1;
                var bottom = r[i + 1][j] != int.MinValue ? r[i + 1][j] + 1 : Helper(mat, i + 1, j, r) + 1;
                var left = r[i][j - 1] != int.MinValue ? r[i][j - 1] + 1 : Helper(mat, i, j - 1, r) + 1;
                var right = r[i][j + 1] != int.MinValue ? r[i][j + 1] + 1 : Helper(mat, i, j + 1, r) + 1;
                return Math.Min(Math.Min(left, right), Math.Min(top, bottom));
            }
        }

        public int[][] UpdateMatrix_Accept(int[][] matrix)
        {
            // Create a bool array -- visited same as input  
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            bool[][] visited = new bool[rows][];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = new bool[columns];
            }

            Queue<Coordinates> queue = new Queue<Coordinates>();

            int[][] dirs = new int[4][];
            dirs[0] = new int[] { 1, 0 };
            dirs[1] = new int[] { -1, 0 };
            dirs[2] = new int[] { 0, 1 };
            dirs[3] = new int[] { 0, -1 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Storing Coordinates of all zero's in queue 
                    // marking them visited in visited array
                    if (matrix[i][j] == 0)
                    {
                        queue.Enqueue(new Coordinates(i, j));
                        visited[i][j] = true;
                    }
                }
            }

            while (queue.Any())
            {
                Coordinates top = queue.Dequeue();
                foreach (int[] dir in dirs)
                {
                    int xx = top.x + dir[0];
                    int yy = top.y + dir[1];
                    if (xx >= 0 && xx < rows && yy >= 0 && yy < columns && !visited[xx][yy])
                    {
                        matrix[xx][yy] = matrix[top.x][top.y] + 1;
                        visited[xx][yy] = true;
                        queue.Enqueue(new Coordinates(xx, yy));
                    }

                }
            }

            return matrix;
        }


        public class Coordinates
        {
            public int x;
            public int y;
            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        public int[][] UpdateMatrix_AcceptDP(int[][] mat)
        {
            var res = new int[mat.Length][];
            for (var i = 0; i < mat.Length; i++)
            {
                res[i] = new int[mat[i].Length];
                for (var j = 0; j < res[i].Length; j++)
                {
                    res[i][j] = int.MaxValue - 10000; //prevent overflow
                }
            }
            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        res[i][j] = 0;
                        continue;
                    }
                    if (i - 1 >= 0)
                    {
                        res[i][j] = Math.Min(res[i][j], res[i - 1][j] + 1);
                    }
                    if (j - 1 >= 0)
                    {
                        res[i][j] = Math.Min(res[i][j], res[i][j - 1] + 1);
                    }
                }
            }
            for (var i = mat.Length - 1; i >= 0; i--)
            {
                for (var j = mat[i].Length - 1; j >= 0; j--)
                {
                    if (mat[i][j] == 0)
                    {
                        res[i][j] = 0;
                        continue;
                    }
                    if (i + 1 < mat.Length)
                    {
                        res[i][j] = Math.Min(res[i][j], res[i + 1][j] + 1);
                    }
                    if (j + 1 < mat[i].Length)
                    {
                        res[i][j] = Math.Min(res[i][j], res[i][j + 1] + 1);
                    }
                }
            }
            return res;
        }
    }
}
