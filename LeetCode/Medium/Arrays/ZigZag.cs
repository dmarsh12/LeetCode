using System.Text;

namespace LeetCode.Medium.Arrays;

public static class ZigZag
{
    // P A Y P A L I S H I   R   I   N  G
    // 0 1 2 3 4 5 6 7 8 9 10 11 12 13
    public static string Execute(string s, int numRows)
    {
        if(numRows == 1 || s.Length <= 1)
        {
            return s;
        }

        string[] solution = new string[numRows];

        int i = 0, direction = 1;
        foreach(char c in s)
        {
            solution[i] += c;

            i += direction;

            if (i == numRows-1 || i==0) direction *= -1;
        }

        return string.Concat(solution);
    }
}