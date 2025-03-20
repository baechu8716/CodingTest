using System;

public class Solution {
    public int solution(int[] array, int height) {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > height)
            {
                result++;
            }
        }
        return result;   
    }
}