using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        List<int> answer = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                bool isHas = false;
                
                for (int j = i - 1; j >= 0; j--)
                {
                    count++;

                    //똑같은 문자가 존재함
                    if (s[i] == s[j])
                    {
                        isHas = true;
                        answer.Add(count);
                        break;
                    }
                }

                //똑같은 문자가 없다면
                if (!isHas)
                {
                    answer.Add(-1);
                }
            }
             return answer.ToArray();
        }
    }