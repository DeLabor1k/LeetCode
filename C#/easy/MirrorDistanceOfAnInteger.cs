public class Solution 
{
    // Task 3783 | Easy
    public int MirrorDistance(int n) 
    {
        int reversed = 0;
        int orig = n;
        int digit = 0;
        while (n != 0)
        {
            digit = n % 10;
            reversed = reversed * 10 + digit;
            n /= 10;
        }
        return Math.Abs(orig - reversed);
        
        if (n == 0) return 0;
    }
}