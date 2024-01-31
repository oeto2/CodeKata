using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        string strN = n.ToString();
        
        int[] answer = new int[strN.Length];
        
        for(int i = 0; i < strN.Length; i++)
        {
            answer[i] = int.Parse(strN[i].ToString());
        }
        
        Array.Reverse(answer);
        
        return answer;
    }
}