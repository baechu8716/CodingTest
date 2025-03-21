using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        if (slice >= n)
        {
            return answer = 1;
        }
        else if (n % slice == 0)
        {
            return n / slice;
        }
        else
        {
            return n / slice + 1;
        }
        
    }
}
