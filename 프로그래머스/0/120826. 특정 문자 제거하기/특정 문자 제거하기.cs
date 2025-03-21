using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        char a = letter[0];
        for (int i = 0; i < my_string.Length; i++)
        {    
            if(my_string[i] == a)
            {
                continue;
            }
            else
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}