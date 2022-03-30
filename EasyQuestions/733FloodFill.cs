using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _733FloodFill
    {

        public int[][] FloodFill1(int[][] image, int sr, int sc, int newColor)
        {
            var color = image[sr][sc];
            if (color == newColor)
            {
                return image;
            }
            Stack<(int x, int y)> pixels = new Stack<(int x, int y)>();
            pixels.Push((sr, sc));//Push the root;
            while (pixels.Count > 0)
            {
                var p = pixels.Pop();
                if (p.x < 0 || p.x >= image.Length) continue;
                if (p.y < 0 || p.y >= image[0].Length) continue;

                if (image[p.x][p.y] == color)
                {
                    image[p.x][p.y] = newColor;

                    pixels.Push((p.x - 1, p.y));
                    pixels.Push((p.x + 1, p.y));
                    pixels.Push((p.x, p.y - 1));
                    pixels.Push((p.x, p.y + 1));
                }

            }
            return image;
        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] != newColor)
                ChangeColor(sr, sc, image, image[sr][sc], newColor);
            return image;
        }

        void ChangeColor(int row, int col, int[][] image, int oldColor, int newColor)
        {
            if (image[row][col] == oldColor)
            {
                image[row][col] = newColor;
                if (row > 0)
                    ChangeColor(row - 1, col, image, oldColor, newColor);
                if (row < image.Length - 1)
                    ChangeColor(row + 1, col, image, oldColor, newColor);
                if (col > 0)
                    ChangeColor(row, col - 1, image, oldColor, newColor);
                if (col < image[0].Length - 1)
                    ChangeColor(row, col + 1, image, oldColor, newColor);
            }
        }
    }
}
