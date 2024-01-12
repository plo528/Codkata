using System;

public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = 0;
        if (num1 > 100 || num2 > 100)
        {
            Console.WriteLine("100이상은 입력불가합니다.");
            return answer;
        }
        answer = num1 * num2;
        return answer;
    }
}
