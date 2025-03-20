using System;

public class Solution {
    public int solution(int n, int k) {
        int sheep = 12000 * n;
        int drink = 2000 * k;
        int answer;
        if ( n / 10 >= 1)
        {
            answer = (sheep + drink) - n / 10 * 2000;
        }
        else
        {
            answer = sheep + drink ;
        }
        return answer;
    }
}