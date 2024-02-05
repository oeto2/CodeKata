using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] nChar = n.ToString().ToCharArray();
        Array.Sort(nChar);
        Array.Reverse(nChar);
        
        answer = Convert.ToInt64(new string(nChar));
        
        return answer;
    }
}