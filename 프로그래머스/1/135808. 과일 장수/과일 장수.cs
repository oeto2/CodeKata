using System;
using System.Linq;
public class Solution
{
    public int solution(int k, int m, int[] score)
    {
        int answer = 0;

        Array.Sort(score);

        int count = 1;
        int min = 9999;
        foreach (var item in score.Reverse())
        {
            if (min > item)
                min = item;

            if (count == m)
            {
                count = 0;
                answer += min * m;
                min = 9999;
            }
            count++;
        }
        return answer;
    }
}