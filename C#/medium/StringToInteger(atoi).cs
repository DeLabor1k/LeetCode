public class Solution 
{
    // Task 8 | Medium
    public int MyAtoi(string s) 
    {
        int i = 0;
        int n = s.Length;
        int sign = 1;
        int result = 0;

        while (i < n && s[i] == ' ')
        {
            i++;
        }
        if (i < n && (s[i] == '+' || s[i] == '-'))
            {
                if (s[i] == '-')
                {
                    sign = -1;
                }
                i++;
            }

        while (i < n && char.IsDigit(s[i]))
        {
            int digit = s[i] - '0';
            
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
        result = result * 10 + digit;
        i++;
        }
        return result * sign;
    }
}