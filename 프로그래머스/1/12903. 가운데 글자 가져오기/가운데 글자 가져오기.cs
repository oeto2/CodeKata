public class Solution
{
        public string solution(string s)
        {
            string answer = "";
		
            int temp = s.Length % 2 == 1 ? 1 : 2;
			
            int length = (s.Length / 2) + (s.Length % 2);

            answer = s.Substring(length - 1, temp);

            return answer;
        }
}