using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        if (slice >= n)
        {
            return answer = 1;
        }
        else if (slice % n  == 0 || n % slice == 0)
        {
            answer = slice >= n ? slice / n : n / slice;
            return answer;
        }
        else
        {
            answer = slice > n ? slice / n  : n / slice + 1;
            return answer;
        }
        
    }
}