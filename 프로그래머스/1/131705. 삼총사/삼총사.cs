using System;

public class Solution {
    public int solution(int[] number) {
        int count = 0;
        for(int i = 0; i < number.Length; i++)
        {
            for(int j = i+1; j < number.Length; j++)
            {
                for(int k = j+1; k < number.Length; k++)
                {
                    if(number[i] + number[j] + number[k] == 0)
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }
}