﻿using System.Text;

namespace LeetCode.Medium;

public static class IntToRoman
{
    private static readonly Dictionary<int, string> _lookup = new Dictionary<int, string>
    {
        {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"}, {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"}, {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
    };

    public static string Execute(int num)
    {
        var roman = new StringBuilder();
        foreach (var kvp in _lookup)
        {
            while (num >= kvp.Key)
            {
                roman.Append(_lookup[kvp.Key]);
                num -= kvp.Key;
            }
        }

        return roman.ToString();
    }
    
}