using System;

public class Solution {
    public int[] solution(int money) {
        int count = 0;
        int[] answer = new int[] {count, money};
        if(money >= 5500)
        {
            
            for (int i = 1; money >= (5500 * i); i++)
            {
                answer[1] -= 5500;
                answer[0]++;
            }
            return answer;
        }
        else
        {
            return answer;
        }
    }
}