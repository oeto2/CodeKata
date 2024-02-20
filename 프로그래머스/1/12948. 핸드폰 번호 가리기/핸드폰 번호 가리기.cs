using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string phone_number) {
         string answer = "";
         List<char> numbers = new List<char>();
         phone_number = new string(phone_number.Reverse().ToArray());           
       
        for (int i = 0; i < phone_number.Length; i++)
        {
          if (i > 3)
             numbers.Add('*');
          else
             numbers.Add(phone_number[i]);
        }   
        
        numbers.Reverse();
        answer = new string(numbers.ToArray());   
        return answer;
    }
}