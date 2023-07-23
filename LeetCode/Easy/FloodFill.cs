using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LeetCode.Easy
{
    /// <summary>
    /// I didn't actually do this... I semi implemented it but thought the actual answer was boring so I'm skipping...
    /// </summary>
    public static class FloodFill
    {
        public static void ExampleOne()
        {
            var image = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            var sr = 1;
            var sc = 1;
            var color = 2;
            Fill(image, sr, sc, color);
        }

        public static void ExampleTwo()
        {
            var image = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 1 } };
            var sr = 0;
            var sc = 0;
            var color = 2;
            Fill(image, sr, sc, color);
        }


        public static int[][] Fill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] != color)
            {
                Fill(image, sr, sc, image[sr][sc], color);
            }
            return image;
        }

        private static void Fill(int[][] image, int sr, int sc, int replacingColor, int newColor)
        {
            image[sr][sc] = newColor;

            if (sr > 0 && image[sr - 1][sc] == replacingColor)
            {
                Fill(image, sr - 1, sc, replacingColor, newColor);
            }
            if (sr < image.Length - 1 && image[sr + 1][sc] == replacingColor)
            {
                Fill(image, sr + 1, sc, replacingColor, newColor);
            }
            if (sc > 0 && image[sr][sc - 1] == replacingColor)
            {
                Fill(image, sr, sc - 1, replacingColor, newColor);
            }
            if (sc < image[sr].Length - 1 && image[sr][sc + 1] == replacingColor)
            {
                Fill(image, sr, sc + 1, replacingColor, newColor);
            }
        }
    }
}
