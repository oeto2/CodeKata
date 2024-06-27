using System;
using System.Linq;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        return strings.OrderBy(o => o[n]).ThenBy(t => t).ToArray();
    }
}