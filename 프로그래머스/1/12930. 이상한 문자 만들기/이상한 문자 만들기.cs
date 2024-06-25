public class Solution {
    public string solution(string s) {
        string answer = "";
        
        //짝수번째인지 확인하는 bool값
        bool evenNum = true;

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
               answer += ' ';
               evenNum = true;
               continue;
            }

            if(evenNum)
            {
              answer += s[i].ToString().ToUpper();
              evenNum = false;
              continue;
            }

            answer += s[i].ToString().ToLower();
            evenNum = true;
        }
        
        return answer;
    }
}