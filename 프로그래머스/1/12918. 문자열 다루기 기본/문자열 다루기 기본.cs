public class Solution {
    public bool solution(string s) {
        bool answer = false;
        
         if(s.Length == 4 || s.Length == 6)
        {
             answer = int.TryParse(s, out int temp);
        }
        
        return answer;
    }
}