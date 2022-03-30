using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _994RottingOranges
    {
        public class Coordinates
        {
            public int row { get; }
            public int col { get; }

            public Coordinates(int r, int c)
            {
                row = r;
                col = c;
            }
        }
        public int OrangesRotting(int[][] grid)
        {
            var freshOrange = 0;
            var queue = new Queue<Coordinates>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                        freshOrange++;
                    else if (grid[i][j] == 2)
                        queue.Enqueue(new Coordinates(i, j));
                }
            }

            if (freshOrange == 0)
                return 0;

            if (queue.Count == 0)
                return -1;

            var queueNext = new Queue<Coordinates>();

            int[][] dirs = new int[4][];
            dirs[0] = new int[] { 1, 0 };
            dirs[1] = new int[] { -1, 0 };
            dirs[2] = new int[] { 0, 1 };
            dirs[3] = new int[] { 0, -1 };

            var result = 0;

            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                foreach (int[] dir in dirs)
                {
                    int r = cur.row + dir[0];
                    int c = cur.col + dir[1];
                    if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length && grid[r][c] == 1 )
                    {
                        queueNext.Enqueue(new Coordinates(r, c));
                        grid[r][c] = 2;
                        freshOrange--;
                        if (freshOrange == 0)
                        {
                            return ++result;
                        }
                    }
                }

                if (queue.Count == 0)
                {
                    if (queueNext.Count > 0)
                    {
                        foreach (var item in queueNext)
                        {
                            queue.Enqueue(item);
                        }
                        queueNext.Clear();
                        result++;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            return result;

        }

    }
}
