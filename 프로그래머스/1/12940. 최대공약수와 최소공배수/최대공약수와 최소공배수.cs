public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {};
        
        int min = GCD(n,m);
        int max = LCM(n,m,min);
        
        answer = new int[]{min,max};
        return answer;
    }
    
     int GCD(int a_, int b_)
        {
            if (b_ == 0) return a_;
            else return GCD(b_, a_ % b_);
        }  
    
     int LCM(int a_, int b_, int gcd_)
        {
            if (gcd_ == 0) return 0;
            int result = (a_ * b_) / gcd_;
            return result;
        }
}