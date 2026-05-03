public class Solution 
{
    // Task 788 | Medium
    public int RotatedDigits(int n) 
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (IsGood(i))
                count++;
        }
        return count;
    }

    private bool IsGood(int num)
    {
        int[] rotate = { 0, 1, 5, -1, -1, 2, 9, -1, 8, 6 };
        int rotated = 0;
        int original = num;
        int multiplier = 1;
    
        while (num > 0)
        {
            int digit = num % 10;
            int rotatedDigit = rotate[digit];
        
            if (rotatedDigit == -1)
                return false;
        
            rotated = rotatedDigit * multiplier + rotated;
            multiplier *= 10;
            num /= 10;
        }
        return rotated != original;
    }
}