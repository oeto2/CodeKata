using System;

public class Solution {
    public bool solution(int x) {
        bool answer = false;
        string stringX = x.ToString();
        int sum = 0;
        
        foreach(char c in stringX)
        {
            sum += Convert.ToInt32(c.ToString());
        }
        
        if(int.Parse(stringX) % sum == 0)
            answer = true;
        
        return answer;
    }
}