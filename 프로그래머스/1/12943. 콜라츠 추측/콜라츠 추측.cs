public class Solution {
    public int solution(int num) {
        int answer = 0;
        
        long number = num;
        
        if(number != 1)
        {
            while(number != 1)
        {
            answer++;
            number = (number % 2 == 0) ? number /= 2 : (number * 3) + 1;
           
            if(answer >= 500 )
            {
                answer = -1;
                break;
            }
        }
        }
        else {answer = 0;}
        
        
        return answer;
    }
}