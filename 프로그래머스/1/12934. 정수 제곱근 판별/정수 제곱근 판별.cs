using System;

public class Solution {
    public long solution(long n) {
        double squareNum = Math.Sqrt(n);
            
        if(squareNum % 1 == 0)
            return (long)((squareNum + 1) * (squareNum + 1));
        
        else return -1;
    }
}