using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1)
        {arr[0] = -1; 
            return arr;
         }
        List<int> numbers = new List<int>();
        int minNum = arr.Min();
        
        for(int i = 0; i< arr.Length; i++)
        {
            if(minNum == arr[i])
                 continue;
            
            numbers.Add(arr[i]);
        }
        
        return numbers.ToArray();
    }
}